using System.Threading.Tasks;
using Abp.Application.Services;
using GARAJ.Sessions.Dto;

namespace GARAJ.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
