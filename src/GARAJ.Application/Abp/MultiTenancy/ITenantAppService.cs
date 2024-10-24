using Abp.Application.Services;
using GARAJ.Abp.MultiTenancy.Dto;

namespace GARAJ.Abp.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

