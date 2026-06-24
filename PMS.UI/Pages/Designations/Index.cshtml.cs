using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PMS.UI.Models.ViewModels.Department;
using PMS.UI.Models.ViewModels.Designation;

namespace PMS.UI.Pages.Designations
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public async Task<PartialViewResult> OnGetCreateNewDesignation()
        {
            var category = new CreateDesignationViewModel();
            return new PartialViewResult
            {
                ViewName = "_Create",
                ViewData = new ViewDataDictionary<CreateDesignationViewModel>(ViewData, category)
            };
        }
    }
}
