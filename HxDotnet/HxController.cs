using Microsoft.AspNetCore.Mvc;

namespace HxDotnet;
public class HxController : Controller
{
#pragma warning disable S6967 // ModelState.IsValid should be called in controller actions
    public ActionResult HxView(string Name, object Model)
#pragma warning restore S6967 // ModelState.IsValid should be called in controller actions
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