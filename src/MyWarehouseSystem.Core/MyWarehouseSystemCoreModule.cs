using Abp.Modules;
using Abp.Reflection.Extensions;
using MyWarehouseSystem.Localization;

namespace MyWarehouseSystem
{
    public class MyWarehouseSystemCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            MyWarehouseSystemLocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = MyWarehouseSystemConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyWarehouseSystemCoreModule).GetAssembly());
        }
    }
}