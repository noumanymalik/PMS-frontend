using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PMS.UI.Pages.CorrectiveActions
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }

        [BindProperty(SupportsGet = true)]
        public string? SearchTerm { get; set; }
    }
}
