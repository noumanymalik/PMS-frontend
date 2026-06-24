using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PMS.UI.Models.ViewModels.User;

namespace PMS.UI.Pages.Users
{
    [Authorize]
    public class ChangePasswordModel : PageModel
    {
        [BindProperty]
        public EditPasswordViewModel ChangePassword { get; set; } = default;
        public async Task<IActionResult> OnGetAsync()
        {
            return Page();
        }
    }
}
