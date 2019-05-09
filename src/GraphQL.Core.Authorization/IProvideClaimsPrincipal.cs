using System.Security.Claims;

namespace GraphQL.Core.Authorization
{
    public interface IProvideClaimsPrincipal
    {
        ClaimsPrincipal User { get; }
    }
}
