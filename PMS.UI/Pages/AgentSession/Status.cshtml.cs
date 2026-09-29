using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PMS.UI.Pages.AgentSession
{
    [Authorize]
    public class StatusModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
