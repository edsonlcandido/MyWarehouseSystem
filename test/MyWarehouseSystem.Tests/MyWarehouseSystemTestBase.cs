using System;
using System.Threading.Tasks;
using Abp.TestBase;
using MyWarehouseSystem.EntityFrameworkCore;
using MyWarehouseSystem.Tests.TestDatas;

namespace MyWarehouseSystem.Tests
{
    public class MyWarehouseSystemTestBase : AbpIntegratedTestBase<MyWarehouseSystemTestModule>
    {
        public MyWarehouseSystemTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<MyWarehouseSystemDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<MyWarehouseSystemDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<MyWarehouseSystemDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyWarehouseSystemDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<MyWarehouseSystemDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<MyWarehouseSystemDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<MyWarehouseSystemDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<MyWarehouseSystemDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
