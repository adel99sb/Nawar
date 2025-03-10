using Microsoft.AspNetCore.Authorization;

namespace Nawar.API.Attributes
{
    public class DynamicAuthorizationHandler : AuthorizationHandler<DynamicAuthorizationRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, DynamicAuthorizationRequirement requirement)
        {
            // Check each condition in the requirement
            foreach (var condition in requirement.Conditions)
            {
                if (condition.Key == "EmailConfirmed")
                {
                    var isEmailConfirmed = context.User.Claims
                        .Any(c => c.Type == "EmailConfirmed" && c.Value == condition.Value.ToString());
                    if (!isEmailConfirmed)
                    {
                        return Task.CompletedTask; // Not approved, do not succeed
                    }
                }
                // You can add more dynamic conditions here based on your requirements
            }

            // If all conditions are met, succeed the requirement
            context.Succeed(requirement);
            return Task.CompletedTask;
        }
    }

}
