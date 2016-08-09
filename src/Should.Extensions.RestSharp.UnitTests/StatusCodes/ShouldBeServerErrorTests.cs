using System;
using System.Net;
using NUnit.Framework;
using RestSharp;
using Should.Core.Exceptions;

namespace Should.Extensions.RestSharp.UnitTests.StatusCodes
{
    [TestFixture]
    public class ShouldBeServerErrorTests
    {
        [TestCase(HttpStatusCode.Continue, false)]
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
        [TestCase(HttpStatusCode.InternalServerError, true)]
        [TestCase(HttpStatusCode.NotImplemented, true)]
        [TestCase(HttpStatusCode.BadGateway, true)]
        [TestCase(HttpStatusCode.ServiceUnavailable, true)]
        [TestCase(HttpStatusCode.GatewayTimeout, true)]
        [TestCase(HttpStatusCode.HttpVersionNotSupported, true)]
        public void ShouldPassShouldBeServerErrorCheck(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeServerError());
            else
            {
                var exception = Assert.Catch(() => response.ShouldBeServerError());

                exception.ShouldNotBeNull();
                exception.ShouldImplement<AssertException>();
            }
        }

        [TestCase(HttpStatusCode.Continue, false)]
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
        [TestCase(HttpStatusCode.InternalServerError, true)]
        [TestCase(HttpStatusCode.NotImplemented, false)]
        [TestCase(HttpStatusCode.BadGateway, false)]
        [TestCase(HttpStatusCode.ServiceUnavailable, false)]
        [TestCase(HttpStatusCode.GatewayTimeout, false)]
        [TestCase(HttpStatusCode.HttpVersionNotSupported, false)]
        public void ShouldPassShouldBeInternalServerError(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeInternalServerError());
            else
                Assert.Throws<EqualException>(() => response.ShouldBeInternalServerError());
        }

        [TestCase(HttpStatusCode.Continue, false)]
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
        [TestCase(HttpStatusCode.NotImplemented, true)]
        [TestCase(HttpStatusCode.BadGateway, false)]
        [TestCase(HttpStatusCode.ServiceUnavailable, false)]
        [TestCase(HttpStatusCode.GatewayTimeout, false)]
        [TestCase(HttpStatusCode.HttpVersionNotSupported, false)]
        public void ShouldPassShouldBeNotImplemented(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeNotImplemented());
            else
                Assert.Throws<EqualException>(() => response.ShouldBeNotImplemented());
        }

        [TestCase(HttpStatusCode.Continue, false)]
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
        [TestCase(HttpStatusCode.BadGateway, true)]
        [TestCase(HttpStatusCode.ServiceUnavailable, false)]
        [TestCase(HttpStatusCode.GatewayTimeout, false)]
        [TestCase(HttpStatusCode.HttpVersionNotSupported, false)]
        public void ShouldPassShouldBeBadGateway(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeBadGateway());
            else
                Assert.Throws<EqualException>(() => response.ShouldBeBadGateway());
        }

        [TestCase(HttpStatusCode.Continue, false)]
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
        [TestCase(HttpStatusCode.ServiceUnavailable, true)]
        [TestCase(HttpStatusCode.GatewayTimeout, false)]
        [TestCase(HttpStatusCode.HttpVersionNotSupported, false)]
        public void ShouldPassShouldBeServiceUnavailable(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeServiceUnavailable());
            else
                Assert.Throws<EqualException>(() => response.ShouldBeServiceUnavailable());
        }

        [TestCase(HttpStatusCode.Continue, false)]
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
        [TestCase(HttpStatusCode.GatewayTimeout, true)]
        [TestCase(HttpStatusCode.HttpVersionNotSupported, false)]
        public void ShouldPassShouldBeGatewayTimeout(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeGatewayTimeout());
            else
                Assert.Throws<EqualException>(() => response.ShouldBeGatewayTimeout());
        }

        [TestCase(HttpStatusCode.Continue, false)]
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
        [TestCase(HttpStatusCode.HttpVersionNotSupported, true)]
        public void ShouldPassShouldBeHttpVersionNotSupported(HttpStatusCode status, bool shouldPass)
        {
            var response = new RestResponse { StatusCode = status };

            if (shouldPass)
                Assert.DoesNotThrow(() => response.ShouldBeHttpVersionNotSupported());
            else
                Assert.Throws<EqualException>(() => response.ShouldBeHttpVersionNotSupported());
        }
    }
}
