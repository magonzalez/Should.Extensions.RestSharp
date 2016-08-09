using System.Net;
using NUnit.Framework;
using RestSharp;
using Should.Core.Exceptions;

namespace Should.Extensions.RestSharp.UnitTests.StatusCodes
{
    [TestFixture]
    public class ShouldBeSuccessTests
    {
        [TestCase(HttpStatusCode.Continue, false)]
        [TestCase(HttpStatusCode.SwitchingProtocols, false)]
        [TestCase(HttpStatusCode.OK, true)]
        [TestCase(HttpStatusCode.Created, true)]
        [TestCase(HttpStatusCode.Accepted, true)]
        [TestCase(HttpStatusCode.NonAuthoritativeInformation, true)]
        [TestCase(HttpStatusCode.NoContent, true)]
        [TestCase(HttpStatusCode.ResetContent, true)]
        [TestCase(HttpStatusCode.PartialContent, true)]
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
        public void ShouldPassShouldBeSuccessCheck(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeSuccess());
            else
            {
                var exception = Assert.Catch(() => response.ShouldBeSuccess());

                exception.ShouldNotBeNull();
                exception.ShouldImplement<AssertException>();
            }
        }

        [TestCase(HttpStatusCode.Continue, false)]
        [TestCase(HttpStatusCode.SwitchingProtocols, false)]
        [TestCase(HttpStatusCode.OK, true)]
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
        public void ShouldPassShouldBeOk(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeOk());
            else
                Assert.Throws<EqualException>(() => response.ShouldBeOk());
        }

        [TestCase(HttpStatusCode.Continue, false)]
        [TestCase(HttpStatusCode.SwitchingProtocols, false)]
        [TestCase(HttpStatusCode.OK, false)]
        [TestCase(HttpStatusCode.Created, true)]
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
        public void ShouldPassShouldBeCreated(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeCreated());
            else
                Assert.Throws<EqualException>(() => response.ShouldBeCreated());
        }

        [TestCase(HttpStatusCode.Continue, false)]
        [TestCase(HttpStatusCode.SwitchingProtocols, false)]
        [TestCase(HttpStatusCode.OK, false)]
        [TestCase(HttpStatusCode.Created, false)]
        [TestCase(HttpStatusCode.Accepted, true)]
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
        public void ShouldPassShouldBeAccepted(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeAccepted());
            else
                Assert.Throws<EqualException>(() => response.ShouldBeAccepted());
        }

        [TestCase(HttpStatusCode.Continue, false)]
        [TestCase(HttpStatusCode.SwitchingProtocols, false)]
        [TestCase(HttpStatusCode.OK, false)]
        [TestCase(HttpStatusCode.Created, false)]
        [TestCase(HttpStatusCode.Accepted, false)]
        [TestCase(HttpStatusCode.NonAuthoritativeInformation, true)]
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
        public void ShouldPassShouldBeNonAuthoritativeInformation(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeNonAuthoritativeInformation());
            else
                Assert.Throws<EqualException>(() => response.ShouldBeNonAuthoritativeInformation());
        }

        [TestCase(HttpStatusCode.Continue, false)]
        [TestCase(HttpStatusCode.SwitchingProtocols, false)]
        [TestCase(HttpStatusCode.OK, false)]
        [TestCase(HttpStatusCode.Created, false)]
        [TestCase(HttpStatusCode.Accepted, false)]
        [TestCase(HttpStatusCode.NonAuthoritativeInformation, false)]
        [TestCase(HttpStatusCode.NoContent, true)]
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
        public void ShouldPassShouldBeNoContent(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeNoContent());
            else
                Assert.Throws<EqualException>(() => response.ShouldBeNoContent());
        }

        [TestCase(HttpStatusCode.Continue, false)]
        [TestCase(HttpStatusCode.SwitchingProtocols, false)]
        [TestCase(HttpStatusCode.OK, false)]
        [TestCase(HttpStatusCode.Created, false)]
        [TestCase(HttpStatusCode.Accepted, false)]
        [TestCase(HttpStatusCode.NonAuthoritativeInformation, false)]
        [TestCase(HttpStatusCode.NoContent, false)]
        [TestCase(HttpStatusCode.ResetContent, true)]
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
        public void ShouldPassShouldBeResetContent(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeResetContent());
            else
                Assert.Throws<EqualException>(() => response.ShouldBeResetContent());
        }

        [TestCase(HttpStatusCode.Continue, false)]
        [TestCase(HttpStatusCode.SwitchingProtocols, false)]
        [TestCase(HttpStatusCode.OK, false)]
        [TestCase(HttpStatusCode.Created, false)]
        [TestCase(HttpStatusCode.Accepted, false)]
        [TestCase(HttpStatusCode.NonAuthoritativeInformation, false)]
        [TestCase(HttpStatusCode.NoContent, false)]
        [TestCase(HttpStatusCode.ResetContent, false)]
        [TestCase(HttpStatusCode.PartialContent, true)]
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
        public void ShouldPassShouldBePartialContent(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBePartialContent());
            else
                Assert.Throws<EqualException>(() => response.ShouldBePartialContent());
        }
    }
}
