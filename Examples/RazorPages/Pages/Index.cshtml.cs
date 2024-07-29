using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Pages;

public class IndexModel(ILogger<IndexModel> logger) : PageModel
{
    private readonly ILogger<IndexModel> logger = logger;

    public void OnGet()
    {
        logger.LogInformation("{Page} visited", nameof(IndexModel));
    }
    public void OnPostAsync()
    {
        // nothing to do
    }

    public void OnPost()
    {
        // nothing to do
    }
}
