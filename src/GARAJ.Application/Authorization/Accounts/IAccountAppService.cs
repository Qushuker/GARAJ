using System.Threading.Tasks;
using Abp.Application.Services;
using GARAJ.Authorization.Accounts.Dto;

namespace GARAJ.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
