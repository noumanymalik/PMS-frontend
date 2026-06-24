using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PMS.UI.Models.ViewModels.User;

namespace PMS.UI.Pages.Roles
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public async Task<PartialViewResult> OnGetCreateNewRole()
        {
            var role = new CreateRoleViewModel();
            return new PartialViewResult
            {
                ViewName = "_Create",
                ViewData = new ViewDataDictionary<CreateRoleViewModel>(ViewData, role)
            };
        }
    }
}
