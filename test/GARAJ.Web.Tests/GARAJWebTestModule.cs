using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using GARAJ.EntityFrameworkCore;
using GARAJ.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace GARAJ.Web.Tests
{
    [DependsOn(
        typeof(GARAJWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class GARAJWebTestModule : AbpModule
    {
        public GARAJWebTestModule(GARAJEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(GARAJWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(GARAJWebMvcModule).Assembly);
        }
    }
}