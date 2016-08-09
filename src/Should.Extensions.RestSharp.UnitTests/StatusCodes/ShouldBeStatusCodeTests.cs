using System.Net;
using NUnit.Framework;
using RestSharp;
using Should.Core.Exceptions;

namespace Should.Extensions.RestSharp.UnitTests.StatusCodes
{
    [TestFixture]
    public class ShouldBeStatusCodeTests
    {
        [TestCase(HttpStatusCode.Continue)]
        [TestCase(HttpStatusCode.SwitchingProtocols)]
        [TestCase(HttpStatusCode.OK)]
        [TestCase(HttpStatusCode.Created)]
        [TestCase(HttpStatusCode.Accepted)]
        [TestCase(HttpStatusCode.NonAuthoritativeInformation)]
        [TestCase(HttpStatusCode.NoContent)]
        [TestCase(HttpStatusCode.ResetContent)]
        [TestCase(HttpStatusCode.PartialContent)]
        [TestCase(HttpStatusCode.Ambiguous)]
        [TestCase(HttpStatusCode.MultipleChoices)]
        [TestCase(HttpStatusCode.Moved)]
        [TestCase(HttpStatusCode.MovedPermanently)]
        [TestCase(HttpStatusCode.Found)]
        [TestCase(HttpStatusCode.Redirect)]
        [TestCase(HttpStatusCode.RedirectMethod)]
        [TestCase(HttpStatusCode.SeeOther)]
        [TestCase(HttpStatusCode.NotModified)]
        [TestCase(HttpStatusCode.UseProxy)]
        [TestCase(HttpStatusCode.Unused)]
        [TestCase(HttpStatusCode.RedirectKeepVerb)]
        [TestCase(HttpStatusCode.TemporaryRedirect)]
        [TestCase(HttpStatusCode.BadRequest)]
        [TestCase(HttpStatusCode.Unauthorized)]
        [TestCase(HttpStatusCode.PaymentRequired)]
        [TestCase(HttpStatusCode.Forbidden)]
        [TestCase(HttpStatusCode.NotFound)]
        [TestCase(HttpStatusCode.MethodNotAllowed)]
        [TestCase(HttpStatusCode.NotAcceptable)]
        [TestCase(HttpStatusCode.ProxyAuthenticationRequired)]
        [TestCase(HttpStatusCode.RequestTimeout)]
        [TestCase(HttpStatusCode.Conflict)]
        [TestCase(HttpStatusCode.Gone)]
        [TestCase(HttpStatusCode.LengthRequired)]
        [TestCase(HttpStatusCode.PreconditionFailed)]
        [TestCase(HttpStatusCode.RequestEntityTooLarge)]
        [TestCase(HttpStatusCode.RequestUriTooLong)]
        [TestCase(HttpStatusCode.UnsupportedMediaType)]
        [TestCase(HttpStatusCode.RequestedRangeNotSatisfiable)]
        [TestCase(HttpStatusCode.ExpectationFailed)]
        //[TestCase(HttpStatusCode.UpgradeRequired)]
        [TestCase(HttpStatusCode.InternalServerError)]
        [TestCase(HttpStatusCode.NotImplemented)]
        [TestCase(HttpStatusCode.BadGateway)]
        [TestCase(HttpStatusCode.ServiceUnavailable)]
        [TestCase(HttpStatusCode.GatewayTimeout)]
        [TestCase(HttpStatusCode.HttpVersionNotSupported)]
        public void ShouldPassShouldBeStatusCode(HttpStatusCode status)
        {
            var response = new RestResponse { StatusCode = status };

            Assert.DoesNotThrow(() => response.ShouldBeStatusCode(status));
        }

        [TestCase(HttpStatusCode.Continue)]
        [TestCase(HttpStatusCode.SwitchingProtocols)]
        [TestCase(HttpStatusCode.OK)]
        [TestCase(HttpStatusCode.Created)]
        [TestCase(HttpStatusCode.Accepted)]
        [TestCase(HttpStatusCode.NonAuthoritativeInformation)]
        [TestCase(HttpStatusCode.NoContent)]
        [TestCase(HttpStatusCode.ResetContent)]
        [TestCase(HttpStatusCode.PartialContent)]
        [TestCase(HttpStatusCode.Ambiguous)]
        [TestCase(HttpStatusCode.MultipleChoices)]
        [TestCase(HttpStatusCode.Moved)]
        [TestCase(HttpStatusCode.MovedPermanently)]
        [TestCase(HttpStatusCode.Found)]
        [TestCase(HttpStatusCode.Redirect)]
        [TestCase(HttpStatusCode.RedirectMethod)]
        [TestCase(HttpStatusCode.SeeOther)]
        [TestCase(HttpStatusCode.NotModified)]
        [TestCase(HttpStatusCode.UseProxy)]
        [TestCase(HttpStatusCode.Unused)]
        [TestCase(HttpStatusCode.RedirectKeepVerb)]
        [TestCase(HttpStatusCode.TemporaryRedirect)]
        [TestCase(HttpStatusCode.BadRequest)]
        [TestCase(HttpStatusCode.Unauthorized)]
        [TestCase(HttpStatusCode.PaymentRequired)]
        [TestCase(HttpStatusCode.Forbidden)]
        [TestCase(HttpStatusCode.NotFound)]
        [TestCase(HttpStatusCode.MethodNotAllowed)]
        [TestCase(HttpStatusCode.NotAcceptable)]
        [TestCase(HttpStatusCode.ProxyAuthenticationRequired)]
        [TestCase(HttpStatusCode.RequestTimeout)]
        [TestCase(HttpStatusCode.Conflict)]
        [TestCase(HttpStatusCode.Gone)]
        [TestCase(HttpStatusCode.LengthRequired)]
        [TestCase(HttpStatusCode.PreconditionFailed)]
        [TestCase(HttpStatusCode.RequestEntityTooLarge)]
        [TestCase(HttpStatusCode.RequestUriTooLong)]
        [TestCase(HttpStatusCode.UnsupportedMediaType)]
        [TestCase(HttpStatusCode.RequestedRangeNotSatisfiable)]
        [TestCase(HttpStatusCode.ExpectationFailed)]
        //[TestCase(HttpStatusCode.UpgradeRequired)]
        [TestCase(HttpStatusCode.InternalServerError)]
        [TestCase(HttpStatusCode.NotImplemented)]
        [TestCase(HttpStatusCode.BadGateway)]
        [TestCase(HttpStatusCode.ServiceUnavailable)]
        [TestCase(HttpStatusCode.GatewayTimeout)]
        [TestCase(HttpStatusCode.HttpVersionNotSupported)]
        public void ShouldNotPassShouldBeStatusCode(HttpStatusCode status)
        {
            var actualStatus = status != HttpStatusCode.OK ? HttpStatusCode.OK : HttpStatusCode.Accepted;
            var response = new RestResponse { StatusCode = actualStatus };

            Assert.Throws<EqualException>(() => response.ShouldBeStatusCode(status));
        }
    }
}
