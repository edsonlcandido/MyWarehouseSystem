using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MyWarehouseSystem
{
    [DependsOn(
        typeof(MyWarehouseSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyWarehouseSystemApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyWarehouseSystemApplicationModule).GetAssembly());
        }
    }
}