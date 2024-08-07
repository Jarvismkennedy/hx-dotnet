using System.Diagnostics;
using HxDotNet.Core.Models;
using HxDotNet.HttpExtensions;
using HxDotNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers;

public class HomeController : HxController
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return HxView();
    }

    public IActionResult Htmx()
    {
        Response
            .HxTriggerAfterSettle(("event1", new { myValue = "myValue" }))
            .HxTrigger("event2")
            .HxTriggerAfterSwap([new ServerEvent("event3", new { anotherValue = true }), "event4"])
            .HxReswap("none")
            .HxStopPolling();
        return HxView("Htmx");
    }

    public IActionResult Privacy()
    {
        return HxView();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(
            new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier }
        );
    }
}
