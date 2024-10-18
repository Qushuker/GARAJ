using System.Threading.Tasks;
using GARAJ.Models.TokenAuth;
using GARAJ.Web.Controllers;
using Shouldly;
using Xunit;

namespace GARAJ.Web.Tests.Controllers
{
    public class HomeController_Tests: GARAJWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}