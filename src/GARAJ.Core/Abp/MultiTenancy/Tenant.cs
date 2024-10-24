using Abp.MultiTenancy;
using GARAJ.Abp.Authorization.Users;

namespace GARAJ.Abp.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
