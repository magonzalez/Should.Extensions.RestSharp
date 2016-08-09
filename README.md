# Should.Extensions.RestSharp
A collection of useful extensions to the Should Assertion Library for testing RestSharp results. Like the Should extensions themselves, these extensions provide assertions only, and therefore are also test runner agnostic.

## Status Code Assertions

The *Should.Extensions.RestSharp* library includes a set of IRestResponse assertions that can be used to test that it's StatusCode is of a particular type or a specific value.

* ShouldBeInformational()

	* ShouldBeContinue()
	* ShouldBeSwitchingProtocols()

* ShouldBeSuccess()

	* ShouldBeOK()
	* ShouldBeCreated()
	* ShouldBeAccepted()
	* ShouldBeNonAuthoritativeInformation()
	* ShouldBeNoContent()
	* ShouldBeResetContent()
	* ShouldBePartialContent()

* ShouldBeRedirection()

	* ShouldBeAmbiguous ()
	* ShouldBeMultipleChoices()
	* ShouldBeMoved()
	* ShouldBeMovedPermanently()
	* ShouldBeFound()
	* ShouldBeRedirect()
	* ShouldBeRedirectMethod()
	* ShouldBeSeeOther()
	* ShouldBeNotModified()
	* ShouldBeUseProxy()
	* ShouldBeUnused()
	* ShouldBeRedirectKeepVerb()
	* ShouldBeTemporaryRedirect()

* ShouldBeClientError()

	* ShouldBeBadRequest()
	* ShouldBeUnauthorized =()
	* ShouldBePaymentRequired()
	* ShouldBeForbidden()
	* ShouldBeNotFound()
	* ShouldBeMethodNotAllowed()
	* ShouldBeNotAcceptable()
	* ShouldBeProxyAuthenticationRequired()
	* ShouldBeRequestTimeout()
	* ShouldBeConflict()
	* ShouldBeGone()
	* ShouldBeLengthRequired()
	* ShouldBePreconditionFailed()
	* ShouldBeRequestEntityTooLarge()
	* ShouldBeRequestUriTooLong ()
	* ShouldBeUnsupportedMediaType()
	* ShouldBeRequestedRangeNotSatisfiable()
	* ShouldBeExpectationFailed()
	* ShouldBeUpgradeRequired()

* ShouldBeServerError()

	* ShouldBeInternalServerError()
	* ShouldBeNotImplemented()
	* ShouldBeBadGateway()
	* ShouldBeServiceUnavailable()
	* ShouldBeGatewayTimeout()
	* ShouldBeHttpVersionNotSupported()

* ShouldBeStatusCode(HtttpStatusCode code)