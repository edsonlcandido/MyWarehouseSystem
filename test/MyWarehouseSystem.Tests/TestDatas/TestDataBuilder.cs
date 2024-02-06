using MyWarehouseSystem.EntityFrameworkCore;

namespace MyWarehouseSystem.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly MyWarehouseSystemDbContext _context;

        public TestDataBuilder(MyWarehouseSystemDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}