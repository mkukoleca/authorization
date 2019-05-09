using System.Threading.Tasks;

namespace GraphQL.Core.Authorization
{
    public interface IAuthorizationRequirement
    {
        Task Authorize(AuthorizationContext context);
    }
}
