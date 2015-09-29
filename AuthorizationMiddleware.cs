using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using Microsoft.Owin;

namespace AuthSpike
{
    public class AuthorizationMiddleware : OwinMiddleware
    {
        public AuthorizationMiddleware(OwinMiddleware next) : base(next)
        {
        }

        public async override Task Invoke(IOwinContext context)
        {
            var identity = context.Authentication.User.Identity as ClaimsIdentity;

            identity.AddClaim(new Claim("/api/cars", "Allow"));

            try
            {
                await Next.Invoke(context);
            }
            catch (Exception ex)
            {
                
            }
        }
    }
}