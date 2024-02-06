using Abp.Application.Services;

namespace MyWarehouseSystem
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MyWarehouseSystemAppServiceBase : ApplicationService
    {
        protected MyWarehouseSystemAppServiceBase()
        {
            LocalizationSourceName = MyWarehouseSystemConsts.LocalizationSourceName;
        }
    }
}