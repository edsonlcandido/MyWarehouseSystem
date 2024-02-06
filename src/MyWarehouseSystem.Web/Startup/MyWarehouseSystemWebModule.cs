using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyWarehouseSystem.Configuration;
using MyWarehouseSystem.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace MyWarehouseSystem.Web.Startup
{
    [DependsOn(
        typeof(MyWarehouseSystemApplicationModule), 
        typeof(MyWarehouseSystemEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class MyWarehouseSystemWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MyWarehouseSystemWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(MyWarehouseSystemConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<MyWarehouseSystemNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(MyWarehouseSystemApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyWarehouseSystemWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyWarehouseSystemWebModule).Assembly);
        }
    }
}
