using MusicLibrary.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace MusicLibrary.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_A_View_Result()
        {
            var underTest = new HomeController();
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
