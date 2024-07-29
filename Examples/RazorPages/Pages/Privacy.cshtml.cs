using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages;

public class PrivacyModel(ILogger<PrivacyModel> logger) : PageModel
{
    private readonly ILogger<PrivacyModel> logger = logger;

    public void OnGet()
    {
        logger.LogInformation("{Page} visited",nameof(PrivacyModel));
    }
}

