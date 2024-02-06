using Microsoft.EntityFrameworkCore;

namespace MyWarehouseSystem.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<MyWarehouseSystemDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for MyWarehouseSystemDbContext */
            //dbContextOptions.UseSqlServer(connectionString);
            dbContextOptions.UseSqlite(@$"Data Source=WarehouseSystem.db");
        }
    }
}
