using Abp.AspNetCore.Mvc.Controllers;

namespace MyWarehouseSystem.Web.Controllers
{
    public abstract class MyWarehouseSystemControllerBase: AbpController
    {
        protected MyWarehouseSystemControllerBase()
        {
            LocalizationSourceName = MyWarehouseSystemConsts.LocalizationSourceName;
        }
    }
}