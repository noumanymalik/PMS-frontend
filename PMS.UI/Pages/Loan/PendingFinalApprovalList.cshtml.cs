using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PMS.UI.Pages.Loan
{
    [Authorize]
    public class PendingFinalApprovalListModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
