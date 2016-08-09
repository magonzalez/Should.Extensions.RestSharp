# Generate build label
if($env:BUILD_NUMBER -ne $null) {
    $env:buildlabel = "Should.Extensions.RestSharp Release $env:BUILD_NUMBER on $(Get-Date -Format g)"
    $env:buildconfig = "Release"
	$env:manualbuild = $false
}
else {
    $env:buildlabel = "Manual Build on $(Get-Date -Format g)"
    $env:buildconfig = "Debug"
	$env:manualbuild = $true
}

Framework "4.0"

properties {
    $projectName = "Should.Extensions.RestSharp"
    $unitTestAssembly = "Should.Extensions.RestSharp.UnitTests.dll"
    $projectConfig = $env:buildconfig
    $base_dir = resolve-path .\
    $source_dir = "$base_dir\src"
    $nunitPath = "$base_dir\tools\NUnit\bin"

    $build_dir = "$base_dir\build"
    $output_dir = "$build_dir\output"
	$results_dir = "$build_dir\results"
    $testCopyIgnorePath = "_ReSharper"
	
	$nuget ="$base_dir\tools\nuget\nuget.exe"
	$nuget_dir = "$build_dir\nuget"
	$nuget_base_path = "$base_dir"
	$nuspec_file = "$source_dir\Should.Extensions.RestSharp\Should.Extensions.RestSharp.nuspec"
}

task default -depends Init, CommonAssemblyInfo, Compile, Test, Nuget -Precondition {
	Write-Host "base_dir                : $base_dir"
	Write-Host "source_dir              : $source_dir"
	Write-Host "build_dir               : $build_dir"
	Write-Host "output_dir              : $output_dir"
	Write-Host "results_dir             : $results_dir"
	Write-Host "nuget_output_dir        : $nuget_dir"

	$true
}

task Init {
    delete_directory $output_dir
    delete_directory $results_dir
    delete_directory $nuget_dir

    create_directory $build_dir
    create_directory $output_dir
    create_directory $results_dir
    create_directory $nuget_dir
}

task Compile -depends Init, DeleteBinFiles {
	write-host "MSBuild config: $projectConfig"
    msbuild /t:Clean`;Rebuild /v:q /nologo /p:Configuration=$projectConfig $source_dir\$projectName.sln /p:NoWarn=1591 /p:Platform="Any CPU" /p:RunOctoPack=true /p:OctoPackEnforceAddingFiles=true
}

task DeleteBinFiles {
	try{
		Get-ChildItem .\src\ -include bin -Recurse | foreach ($_) { remove-item $_.fullname -Force -Recurse }
		Get-ChildItem .\src\ -include obj -Recurse | foreach ($_) { remove-item $_.fullname -Force -Recurse }
	} catch {
		write-host "Error Deleting Bin Files"
	}
}

task Test {
    copy_all_assemblies_for_test $output_dir

	if($env:manualbuild = $true) {
		exec {
			& $nunitPath\nunit-console.exe $output_dir\$unitTestAssembly /xml=$results_dir\TestResult.xml
		}

	} else {
		exec {
			& $nunitPath\nunit-console.exe $output_dir\$unitTestAssembly /nologo /nodots /xml=$results_dir\TestResult.xml
		}
	}
}

task Nuget {
    $buildNumber = Generate-VersionNumber
	"building version:  $buildNumber"
		$nugetBuildNumber = $buildNumber

	if ($buildNumber -match "(\d+\.\d+\.\d+\.\d+)*") {
		$nugetBuildNumber = $matches[1]
	}

	exec { invoke-expression "$nuget pack $nuspec_file -BasePath $nuget_base_path  -Version $nugetBuildNumber -OutputDirectory $nuget_dir" }
}


task CommonAssemblyInfo -Precondition { return $env:BUILD_NUMBER -ne $null } {
    $version = Generate-VersionNumber
    Update-AssemblyInfoFiles $version
}

function global:Generate-VersionNumber {
  if($env:BUILD_NUMBER -ne $null)
  {
    return $env:BUILD_NUMBER
  }
  else
  {
    return "0.0.0.0"
  }
}

function global:Update-AssemblyInfoFiles ([string] $version) {
    $commonAssemblyInfo = "$source_dir\CommonAssemblyInfo.cs"

    $assemblyDescriptionPattern = 'AssemblyDescription\("(.*?)"\)'
    $assemblyDescription = 'AssemblyDescription("' + $env:buildlabel + '")';

    $assemblyVersionPattern = 'AssemblyVersion\("[0-9]+(\.([0-9]+|\*)){1,3}"\)'
    $assemblyVersion = 'AssemblyVersion("' + $version + '")';

    $fileVersionPattern = 'AssemblyFileVersion\("[0-9]+(\.([0-9]+|\*)){1,3}"\)'
    $fileVersion = 'AssemblyFileVersion("' + $version + '")';

    Get-ChildItem $source_dir -r -filter AssemblyInfo.cs | ForEach-Object {
        $filename = $_.Directory.ToString() + '\' + $_.Name
        $filename + ' -> ' + $version

        # If you are using a source control that requires to check-out files before
        # modifying them, make sure to check-out the file here.
        # For example, TFS will require the following command:
        # tf checkout $filename

        (Get-Content $commonAssemblyInfo) | ForEach-Object {
            % {$_ -replace $assemblyVersionPattern, $assemblyVersion } |
            % {$_ -replace $assemblyDescriptionPattern, $assemblyDescription } |
            % {$_ -replace $fileVersionPattern, $fileVersion }
        } | Set-Content $filename
    }
}

function global:copy_files($source,$destination,$exclude=@()){
    create_directory $destination

    Get-ChildItem $source -Recurse -Exclude $exclude | Copy-Item -Destination {Join-Path $destination $_.FullName.Substring($source.length)}
}

function global:copy_all_assemblies_for_test($destination){
  create_directory $destination
  copy_and_flatten $source_dir *.exe $destination
  copy_and_flatten $source_dir *.dll $destination
  copy_and_flatten $source_dir *.config $destination
  copy_and_flatten $source_dir *.xml $destination
  copy_and_flatten $source_dir *.pdb $destination
  copy_and_flatten $source_dir *.sql $destination
  copy_and_flatten $source_dir *.xlsx $destination
}

function global:copy_and_flatten ($source,$filter,$dest) {
  ls $source -filter $filter  -r | Where-Object{!$_.FullName.Contains("$testCopyIgnorePath") -and !$_.FullName.Contains("packages") }| cp -dest $dest -force
}

function global:delete_file($file) {
    if($file) { remove-item $file -force -ErrorAction SilentlyContinue | out-null }
}

function global:delete_directory($directory_name)
{
  rd $directory_name -recurse -force  -ErrorAction SilentlyContinue | out-null
}

function global:delete_files_in_dir($dir)
{
    get-childitem $dir -recurse | foreach ($_) {remove-item $_.fullname}
}

function global:create_directory($directory_name)
{
  mkdir $directory_name  -ErrorAction SilentlyContinue  | out-null
}
