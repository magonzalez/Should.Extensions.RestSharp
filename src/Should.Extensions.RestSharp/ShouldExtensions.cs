using System.Net;
using RestSharp;

namespace Should.Extensions.RestSharp
{
    public static class ShouldExtensions
    {
        public static void ShouldBeInformational(this IRestResponse response)
        {
            response.StatusCode.ShouldBeGreaterThanOrEqualTo(HttpStatusCode.Continue);
            response.StatusCode.ShouldBeLessThan(HttpStatusCode.OK);
        }

        public static void ShouldBeContinue(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.Continue);
        }

        public static void ShouldBeSwitchingProtocols(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.SwitchingProtocols);
        }

        public static void ShouldBeSuccess(this IRestResponse response)
        {
            response.StatusCode.ShouldBeGreaterThanOrEqualTo(HttpStatusCode.OK);
            response.StatusCode.ShouldBeLessThan(HttpStatusCode.Ambiguous);
        }

        public static void ShouldBeOk(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.OK);
        }

        public static void ShouldBeCreated(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.Created);
        }

        public static void ShouldBeAccepted(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.Accepted);
        }

        public static void ShouldBeNonAuthoritativeInformation(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.NonAuthoritativeInformation);
        }

        public static void ShouldBeNoContent(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.NoContent);
        }

        public static void ShouldBeResetContent(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.ResetContent);
        }

        public static void ShouldBePartialContent(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.PartialContent);
        }

        public static void ShouldBeRedirection(this IRestResponse response)
        {
            response.StatusCode.ShouldBeGreaterThanOrEqualTo(HttpStatusCode.Ambiguous);
            response.StatusCode.ShouldBeLessThan(HttpStatusCode.BadRequest);
        }

        public static void ShouldBeAmbiguous(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.Ambiguous);
        }

        public static void ShouldBeMultipleChoices(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.MultipleChoices);
        }

        public static void ShouldBeMoved(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.Moved);
        }

        public static void ShouldBeMovedPermanently(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.MovedPermanently);
        }

        public static void ShouldBeFound(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.Found);
        }

        public static void ShouldBeRedirect(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.Redirect);
        }

        public static void ShouldBeRedirectMethod(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.RedirectMethod);
        }

        public static void ShouldBeSeeOther(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.SeeOther);
        }

        public static void ShouldBeNotModified(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.NotModified);
        }

        public static void ShouldBeUseProxy(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.UseProxy);
        }

        public static void ShouldBeUnused(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.Unused);
        }

        public static void ShouldBeRedirectKeepVerb(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.RedirectKeepVerb);
        }

        public static void ShouldBeTemporaryRedirect(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.TemporaryRedirect);
        }

        public static void ShouldBeClientError(this IRestResponse response)
        {
            response.StatusCode.ShouldBeGreaterThanOrEqualTo(HttpStatusCode.BadRequest);
            response.StatusCode.ShouldBeLessThan(HttpStatusCode.InternalServerError);
        }

        public static void ShouldBeBadRequest(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.BadRequest);
        }

        public static void ShouldBeUnauthorized(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.Unauthorized);
        }

        public static void ShouldBePaymentRequired(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.PaymentRequired);
        }

        public static void ShouldBeForbidden(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.Forbidden);
        }

        public static void ShouldBeNotFound(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.NotFound);
        }

        public static void ShouldBeMethodNotAllowed(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.MethodNotAllowed);
        }

        public static void ShouldBeNotAcceptable(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.NotAcceptable);
        }

        public static void ShouldBeProxyAuthenticationRequired(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.ProxyAuthenticationRequired);
        }

        public static void ShouldBeRequestTimeout(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.RequestTimeout);
        }

        public static void ShouldBeConflict(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.Conflict);
        }

        public static void ShouldBeGone(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.Gone);
        }

        public static void ShouldBeLengthRequired(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.LengthRequired);
        }

        public static void ShouldBePreconditionFailed(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.PreconditionFailed);
        }

        public static void ShouldBeRequestEntityTooLarge(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.RequestEntityTooLarge);
        }

        public static void ShouldBeRequestUriTooLong(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.RequestUriTooLong);
        }

        public static void ShouldBeUnsupportedMediaType(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.UnsupportedMediaType);
        }

        public static void ShouldBeRequestedRangeNotSatisfiable(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.RequestedRangeNotSatisfiable);
        }

        public static void ShouldBeExpectationFailed(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.ExpectationFailed);
        }

        //public static void ShouldBeUpgradeRequired(this IRestResponse response)
        //{
        //    response.ShouldBeStatusCode(HttpStatusCode.UpgradeRequired);
        //}

        public static void ShouldBeServerError(this IRestResponse response)
        {
            response.StatusCode.ShouldBeGreaterThanOrEqualTo(HttpStatusCode.InternalServerError);
        }

        public static void ShouldBeInternalServerError(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.InternalServerError);
        }

        public static void ShouldBeNotImplemented(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.NotImplemented);
        }

        public static void ShouldBeBadGateway(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.BadGateway);
        }

        public static void ShouldBeServiceUnavailable(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.ServiceUnavailable);
        }

        public static void ShouldBeGatewayTimeout(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.GatewayTimeout);
        }

        public static void ShouldBeHttpVersionNotSupported(this IRestResponse response)
        {
            response.ShouldBeStatusCode(HttpStatusCode.HttpVersionNotSupported);
        }

        public static void ShouldBeStatusCode(this IRestResponse response, HttpStatusCode statusCode)
        {
            response.StatusCode.ShouldEqual(statusCode);
        }
    }
}
