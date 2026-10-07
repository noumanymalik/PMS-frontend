using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PMS.UI.Pages.OutboundSales
{
    [Authorize]
    public class SalesStatusModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
