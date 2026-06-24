using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PMS.UI.Pages.Employees
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty(SupportsGet = true)]
        public string? SearchTerm { get; set; }
    }
}
