using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GARAJ.Abp.Authorization;

namespace GARAJ
{
    [DependsOn(
        typeof(GARAJCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class GARAJApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<GARAJAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(GARAJApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
