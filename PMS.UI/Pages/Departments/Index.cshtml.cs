using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PMS.UI.Models.ViewModels.Department;

namespace PMS.UI.Pages.Departments
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public async Task<PartialViewResult> OnGetCreateNewDepartment()
        {
            var category = new CreateDepartmentViewModel();
            return new PartialViewResult
            {
                ViewName = "_Create",
                ViewData = new ViewDataDictionary<CreateDepartmentViewModel>(ViewData, category)
            };
        }
    }
}
