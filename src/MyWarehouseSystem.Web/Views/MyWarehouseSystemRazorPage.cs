using Abp.AspNetCore.Mvc.Views;

namespace MyWarehouseSystem.Web.Views
{
    public abstract class MyWarehouseSystemRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected MyWarehouseSystemRazorPage()
        {
            LocalizationSourceName = MyWarehouseSystemConsts.LocalizationSourceName;
        }
    }
}
