using Xunit;
using playground_api.Controllers;

namespace playground_api_tests;

public class BasicTests
{
    [Fact]
    public void TestCorrectActiveMessage()
    {
        HomeController HomeController = new HomeController(null);
        var indexResult = HomeController.Index();
        Assert.Equal("\"Der Spielplatz-Service ist aktiv.\"", indexResult.Value);
    }
}