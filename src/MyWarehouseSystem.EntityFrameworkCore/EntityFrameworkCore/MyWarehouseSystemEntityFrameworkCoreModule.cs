using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyWarehouseSystem.EntityFrameworkCore
{
    [DependsOn(
        typeof(MyWarehouseSystemCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class MyWarehouseSystemEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyWarehouseSystemEntityFrameworkCoreModule).GetAssembly());
        }
    }
}