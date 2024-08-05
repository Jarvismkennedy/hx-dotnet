using HxDotNet.Core.Models;
using HxDotNet.HttpExtensions;
using Microsoft.AspNetCore.Mvc;

namespace HxDotNet.Mvc;

/// <summary>
/// Controller that extends from <see cref="Controller"/>, adding htmx specific functionality.
/// </summary>
public class HxController : Controller
{
    /// <summary>
    /// Returns <see cref="Controller.View()"/> if the request was not sent by htmx, or if the <see cref="HxRequestHeaders.HxHistoryRestoreRequest"/> header is set to true.
    /// Otherwise it returns <see cref="Controller.PartialView()"/>
    /// </summary>
    /// <param name="Name"></param>
    /// <param name="Model"></param>
    /// <returns></returns>
    [NonAction]
    public ActionResult HxView(string? Name = null, object? Model = null)
    {
        HxRequestHeaders headers = HttpContext.Request.GetHxHeaders();
        if (
            headers.HxRequest is not null
            && !string.Equals(
                headers.HxHistoryRestoreRequest,
                "true",
                StringComparison.OrdinalIgnoreCase
            )
        )
        {
            return PartialView(Name, Model);
        }

        return View(Name, Model);
    }
}
