using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PMS.UI.Pages.Leaves
{
    [Authorize]
    public class PendingModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
