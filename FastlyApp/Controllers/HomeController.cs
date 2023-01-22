namespace FastlyApp.Controllers;

using FastlyApp.Logic;
using Microsoft.AspNetCore.Mvc;

[Route("{controller}")]
public class HomeController : Controller
{
    [HttpGet]
    [Route("foo")]
    [CacheOnFastly(MaxAge = 60)]
    public IActionResult Foo()
    {
        return Content($"Foo cached {DateTime.Now}");
    }


    [HttpGet]
    [Route("bar")]
    public IActionResult Bar()
    {
        return Content($"Bar {DateTime.Now}");
    }
}
