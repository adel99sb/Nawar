using Microsoft.AspNetCore.Authorization;

namespace Nawar.API.Attributes
{
    public class DynamicAuthorizationRequirement : IAuthorizationRequirement
    {
        public string PolicyName { get; }
        public Dictionary<string, object> Conditions { get; }

        public DynamicAuthorizationRequirement(string policyName, Dictionary<string, object> conditions)
        {
            PolicyName = policyName;
            Conditions = conditions;
        }
    }
}
