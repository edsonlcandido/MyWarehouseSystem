using MyWarehouseSystem.Configuration;
using MyWarehouseSystem.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyWarehouseSystem.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class MyWarehouseSystemDbContextFactory : IDesignTimeDbContextFactory<MyWarehouseSystemDbContext>
    {
        public MyWarehouseSystemDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MyWarehouseSystemDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(MyWarehouseSystemConsts.ConnectionStringName)
            );

            return new MyWarehouseSystemDbContext(builder.Options);
        }
    }
}