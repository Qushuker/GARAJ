using Abp.Application.Features;
using Abp.Domain.Repositories;
using Abp.MultiTenancy;
using GARAJ.Abp.Authorization.Users;
using GARAJ.Abp.Editions;

namespace GARAJ.Abp.MultiTenancy
{
    public class TenantManager : AbpTenantManager<Tenant, User>
    {
        public TenantManager(
            IRepository<Tenant> tenantRepository, 
            IRepository<TenantFeatureSetting, long> tenantFeatureRepository, 
            EditionManager editionManager,
            IAbpZeroFeatureValueStore featureValueStore) 
            : base(
                tenantRepository, 
                tenantFeatureRepository, 
                editionManager,
                featureValueStore)
        {
        }
    }
}
