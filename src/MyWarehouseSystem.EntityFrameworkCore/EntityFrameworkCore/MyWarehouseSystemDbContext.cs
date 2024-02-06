using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MyWarehouseSystem.EntityFrameworkCore
{
    public class MyWarehouseSystemDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public MyWarehouseSystemDbContext(DbContextOptions<MyWarehouseSystemDbContext> options) 
            : base(options)
        {

        }
    }
}
