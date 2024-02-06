using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyWarehouseSystem.Web.Startup;
namespace MyWarehouseSystem.Web.Tests
{
    [DependsOn(
        typeof(MyWarehouseSystemWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class MyWarehouseSystemWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyWarehouseSystemWebTestModule).GetAssembly());
        }
    }
}