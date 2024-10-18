using Abp.Application.Services;
using GARAJ.MultiTenancy.Dto;

namespace GARAJ.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

