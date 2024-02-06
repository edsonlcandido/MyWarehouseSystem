using System.Threading.Tasks;
using MyWarehouseSystem.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyWarehouseSystem.Web.Tests.Controllers
{
    public class HomeController_Tests: MyWarehouseSystemWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}
