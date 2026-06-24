using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PMS.UI.Pages.Employees
{
    [Authorize]
    public class HierarchyModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
