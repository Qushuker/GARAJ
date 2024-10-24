using System.Threading.Tasks;
using Abp.Application.Services;
using GARAJ.Abp.Authorization.Accounts.Dto;

namespace GARAJ.Abp.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
