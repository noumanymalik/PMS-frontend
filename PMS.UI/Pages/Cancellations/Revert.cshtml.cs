using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PMS.UI.Pages.Cancellation
{
    [Authorize]
    public class RevertModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
