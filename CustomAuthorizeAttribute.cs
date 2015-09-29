using System.Security.Claims;
using System.Web.Http;
using System.Web.Http.Controllers;

namespace AuthSpike
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            var identity = actionContext.RequestContext.Principal.Identity as ClaimsIdentity;

            if(identity.HasClaim(claim => claim.Type == actionContext.Request.RequestUri.AbsolutePath))
            {
                return true;
            }

            return false;
        }
    }
}