using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PMS.UI.Pages.Loan
{
    [Authorize]
    public class LoanStatusModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
