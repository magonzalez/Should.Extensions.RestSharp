using FizzWare.NBuilder;

namespace Should.Extensions.RestSharp.UnitTests.Models
{
    public static class TestModelBuilder
    {
        public static TModel Build<TModel>()
        {
            return Builder<TModel>.CreateNew().Build();
        }
    }
}
