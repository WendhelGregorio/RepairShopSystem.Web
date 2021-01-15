using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBSIS401.WEB.Infrastructures.Domain.Helper
{
    public class AuthorizeAdminRequirementHandler : AuthorizationHandler<AuthorizeAdminRequirement>
    {
        public AuthorizeAdminRequirementHandler() { }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, AuthorizeAdminRequirement requirement)
        {
            if (!WebUser.IsInRole(Infrastructures.Domain.Enums.Role.Admin))
            {
                context.Fail();

                return Task.CompletedTask;
            }

            context.Succeed(requirement);
            return Task.CompletedTask;
        }
    }

    public class AuthorizeAdminRequirement : IAuthorizationRequirement
    {
    }
}