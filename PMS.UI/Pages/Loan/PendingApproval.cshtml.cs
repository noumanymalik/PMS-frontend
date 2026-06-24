using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PMS.UI.Pages.Loan
{
    [Authorize]
    public class PendingApprovalModel : PageModel
    {
        [FromQuery(Name = "Id")]
        public int LoanId { get; set; }
        public void OnGet()
        {
        }
    }
}
