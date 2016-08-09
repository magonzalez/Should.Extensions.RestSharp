using System.Net;
using NUnit.Framework;
using RestSharp;
using Should.Core.Exceptions;

namespace Should.Extensions.RestSharp.UnitTests.StatusCodes
{
    [TestFixture]
    public class ShouldBeInformationalTests
    {
        [TestCase(HttpStatusCode.Continue, true)]
        [TestCase(HttpStatusCode.SwitchingProtocols, true)]
        [TestCase(HttpStatusCode.OK, false)]
        [TestCase(HttpStatusCode.Created, false)]
        [TestCase(HttpStatusCode.Accepted, false)]
        [TestCase(HttpStatusCode.NonAuthoritativeInformation, false)]
        [TestCase(HttpStatusCode.NoContent, false)]
        [TestCase(HttpStatusCode.ResetContent, false)]
        [TestCase(HttpStatusCode.PartialContent, false)]
        [TestCase(HttpStatusCode.Ambiguous, false)]
        [TestCase(HttpStatusCode.MultipleChoices, false)]
        [TestCase(HttpStatusCode.Moved, false)]
        [TestCase(HttpStatusCode.MovedPermanently, false)]
        [TestCase(HttpStatusCode.Found, false)]
        [TestCase(HttpStatusCode.Redirect, false)]
        [TestCase(HttpStatusCode.RedirectMethod, false)]
        [TestCase(HttpStatusCode.SeeOther, false)]
        [TestCase(HttpStatusCode.NotModified, false)]
        [TestCase(HttpStatusCode.UseProxy, false)]
        [TestCase(HttpStatusCode.Unused, false)]
        [TestCase(HttpStatusCode.RedirectKeepVerb, false)]
        [TestCase(HttpStatusCode.TemporaryRedirect, false)]
        [TestCase(HttpStatusCode.BadRequest, false)]
        [TestCase(HttpStatusCode.Unauthorized, false)]
        [TestCase(HttpStatusCode.PaymentRequired, false)]
        [TestCase(HttpStatusCode.Forbidden, false)]
        [TestCase(HttpStatusCode.NotFound, false)]
        [TestCase(HttpStatusCode.MethodNotAllowed, false)]
        [TestCase(HttpStatusCode.NotAcceptable, false)]
        [TestCase(HttpStatusCode.ProxyAuthenticationRequired, false)]
        [TestCase(HttpStatusCode.RequestTimeout, false)]
        [TestCase(HttpStatusCode.Conflict, false)]
        [TestCase(HttpStatusCode.Gone, false)]
        [TestCase(HttpStatusCode.LengthRequired, false)]
        [TestCase(HttpStatusCode.PreconditionFailed, false)]
        [TestCase(HttpStatusCode.RequestEntityTooLarge, false)]
        [TestCase(HttpStatusCode.RequestUriTooLong, false)]
        [TestCase(HttpStatusCode.UnsupportedMediaType, false)]
        [TestCase(HttpStatusCode.RequestedRangeNotSatisfiable, false)]
        [TestCase(HttpStatusCode.ExpectationFailed, false)]
        //[TestCase(HttpStatusCode.UpgradeRequired, false, false)]
        [TestCase(HttpStatusCode.InternalServerError, false)]
        [TestCase(HttpStatusCode.NotImplemented, false)]
        [TestCase(HttpStatusCode.BadGateway, false)]
        [TestCase(HttpStatusCode.ServiceUnavailable, false)]
        [TestCase(HttpStatusCode.GatewayTimeout, false)]
        [TestCase(HttpStatusCode.HttpVersionNotSupported, false)]
        public void ShouldPassShouldBeInformationalCheck(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeInformational());
            else
            {
                var exception = Assert.Catch(() => response.ShouldBeInformational());

                exception.ShouldNotBeNull();
                exception.ShouldImplement<AssertException>();
            }
        }

        [TestCase(HttpStatusCode.Continue, true)]
        [TestCase(HttpStatusCode.SwitchingProtocols, false)]
        [TestCase(HttpStatusCode.OK, false)]
        [TestCase(HttpStatusCode.Created, false)]
        [TestCase(HttpStatusCode.Accepted, false)]
        [TestCase(HttpStatusCode.NonAuthoritativeInformation, false)]
        [TestCase(HttpStatusCode.NoContent, false)]
        [TestCase(HttpStatusCode.ResetContent, false)]
        [TestCase(HttpStatusCode.PartialContent, false)]
        [TestCase(HttpStatusCode.Ambiguous, false)]
        [TestCase(HttpStatusCode.MultipleChoices, false)]
        [TestCase(HttpStatusCode.Moved, false)]
        [TestCase(HttpStatusCode.MovedPermanently, false)]
        [TestCase(HttpStatusCode.Found, false)]
        [TestCase(HttpStatusCode.Redirect, false)]
        [TestCase(HttpStatusCode.RedirectMethod, false)]
        [TestCase(HttpStatusCode.SeeOther, false)]
        [TestCase(HttpStatusCode.NotModified, false)]
        [TestCase(HttpStatusCode.UseProxy, false)]
        [TestCase(HttpStatusCode.Unused, false)]
        [TestCase(HttpStatusCode.RedirectKeepVerb, false)]
        [TestCase(HttpStatusCode.TemporaryRedirect, false)]
        [TestCase(HttpStatusCode.BadRequest, false)]
        [TestCase(HttpStatusCode.Unauthorized, false)]
        [TestCase(HttpStatusCode.PaymentRequired, false)]
        [TestCase(HttpStatusCode.Forbidden, false)]
        [TestCase(HttpStatusCode.NotFound, false)]
        [TestCase(HttpStatusCode.MethodNotAllowed, false)]
        [TestCase(HttpStatusCode.NotAcceptable, false)]
        [TestCase(HttpStatusCode.ProxyAuthenticationRequired, false)]
        [TestCase(HttpStatusCode.RequestTimeout, false)]
        [TestCase(HttpStatusCode.Conflict, false)]
        [TestCase(HttpStatusCode.Gone, false)]
        [TestCase(HttpStatusCode.LengthRequired, false)]
        [TestCase(HttpStatusCode.PreconditionFailed, false)]
        [TestCase(HttpStatusCode.RequestEntityTooLarge, false)]
        [TestCase(HttpStatusCode.RequestUriTooLong, false)]
        [TestCase(HttpStatusCode.UnsupportedMediaType, false)]
        [TestCase(HttpStatusCode.RequestedRangeNotSatisfiable, false)]
        [TestCase(HttpStatusCode.ExpectationFailed, false)]
        //[TestCase(HttpStatusCode.UpgradeRequired, false, false)]
        [TestCase(HttpStatusCode.InternalServerError, false)]
        [TestCase(HttpStatusCode.NotImplemented, false)]
        [TestCase(HttpStatusCode.BadGateway, false)]
        [TestCase(HttpStatusCode.ServiceUnavailable, false)]
        [TestCase(HttpStatusCode.GatewayTimeout, false)]
        [TestCase(HttpStatusCode.HttpVersionNotSupported, false)]
        public void ShouldPassShouldBeContinueCheck(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeContinue());
            else
                Assert.Throws<EqualException>(() => response.ShouldBeContinue());
        }

        [TestCase(HttpStatusCode.Continue, false)]
        [TestCase(HttpStatusCode.SwitchingProtocols, true)]
        [TestCase(HttpStatusCode.OK, false)]
        [TestCase(HttpStatusCode.Created, false)]
        [TestCase(HttpStatusCode.Accepted, false)]
        [TestCase(HttpStatusCode.NonAuthoritativeInformation, false)]
        [TestCase(HttpStatusCode.NoContent, false)]
        [TestCase(HttpStatusCode.ResetContent, false)]
        [TestCase(HttpStatusCode.PartialContent, false)]
        [TestCase(HttpStatusCode.Ambiguous, false)]
        [TestCase(HttpStatusCode.MultipleChoices, false)]
        [TestCase(HttpStatusCode.Moved, false)]
        [TestCase(HttpStatusCode.MovedPermanently, false)]
        [TestCase(HttpStatusCode.Found, false)]
        [TestCase(HttpStatusCode.Redirect, false)]
        [TestCase(HttpStatusCode.RedirectMethod, false)]
        [TestCase(HttpStatusCode.SeeOther, false)]
        [TestCase(HttpStatusCode.NotModified, false)]
        [TestCase(HttpStatusCode.UseProxy, false)]
        [TestCase(HttpStatusCode.Unused, false)]
        [TestCase(HttpStatusCode.RedirectKeepVerb, false)]
        [TestCase(HttpStatusCode.TemporaryRedirect, false)]
        [TestCase(HttpStatusCode.BadRequest, false)]
        [TestCase(HttpStatusCode.Unauthorized, false)]
        [TestCase(HttpStatusCode.PaymentRequired, false)]
        [TestCase(HttpStatusCode.Forbidden, false)]
        [TestCase(HttpStatusCode.NotFound, false)]
        [TestCase(HttpStatusCode.MethodNotAllowed, false)]
        [TestCase(HttpStatusCode.NotAcceptable, false)]
        [TestCase(HttpStatusCode.ProxyAuthenticationRequired, false)]
        [TestCase(HttpStatusCode.RequestTimeout, false)]
        [TestCase(HttpStatusCode.Conflict, false)]
        [TestCase(HttpStatusCode.Gone, false)]
        [TestCase(HttpStatusCode.LengthRequired, false)]
        [TestCase(HttpStatusCode.PreconditionFailed, false)]
        [TestCase(HttpStatusCode.RequestEntityTooLarge, false)]
        [TestCase(HttpStatusCode.RequestUriTooLong, false)]
        [TestCase(HttpStatusCode.UnsupportedMediaType, false)]
        [TestCase(HttpStatusCode.RequestedRangeNotSatisfiable, false)]
        [TestCase(HttpStatusCode.ExpectationFailed, false)]
        //[TestCase(HttpStatusCode.UpgradeRequired, false, false)]
        [TestCase(HttpStatusCode.InternalServerError, false)]
        [TestCase(HttpStatusCode.NotImplemented, false)]
        [TestCase(HttpStatusCode.BadGateway, false)]
        [TestCase(HttpStatusCode.ServiceUnavailable, false)]
        [TestCase(HttpStatusCode.GatewayTimeout, false)]
        [TestCase(HttpStatusCode.HttpVersionNotSupported, false)]
        public void ShouldPassShouldBeSwitchingProtocols(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeSwitchingProtocols());
            else
                Assert.Throws<EqualException>(() => response.ShouldBeSwitchingProtocols());
        }
    }
}
