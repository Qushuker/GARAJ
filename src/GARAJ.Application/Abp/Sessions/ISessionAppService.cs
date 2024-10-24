using System.Threading.Tasks;
using Abp.Application.Services;
using GARAJ.Abp.Sessions.Dto;

namespace GARAJ.Abp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
