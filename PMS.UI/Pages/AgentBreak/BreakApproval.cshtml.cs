using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PMS.UI.Pages.AgentBreak
{
    [Authorize]
    public class BreakApprovalModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
