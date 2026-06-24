using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PMS.UI.Pages.Roles
{
    [Authorize]
    public class PermissionsModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
