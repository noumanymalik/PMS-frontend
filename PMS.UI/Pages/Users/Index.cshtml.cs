using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PMS.UI.Models.ViewModels.User;

namespace PMS.UI.Pages.Users
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public async Task<PartialViewResult> OnGetCreateNewUser()
        {
            var user = new CreateUserViewModel();
            return new PartialViewResult
            {
                ViewName = "_Create",
                ViewData = new ViewDataDictionary<CreateUserViewModel>(ViewData, user)
            };
        }
    }
}
