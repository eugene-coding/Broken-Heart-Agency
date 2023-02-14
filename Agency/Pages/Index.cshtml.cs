using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Agency.Pages;
public class IndexModel : PageModel
{
    public void OnGet()
    {
        var random = new Random();

        ViewData["Value"] = random.Next(1000, 9999);
    }
}
