using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PMS.UI.Models.ViewModels.Attendance;
using PMS.UI.Models.ViewModels.Transport;

namespace PMS.UI.Pages.Legends
{
    public class IndexModel : PageModel
    {
        public async Task<PartialViewResult> OnGetCreateNewLegend()
        {
            var legend = new CreateLegendViewModel();
            return new PartialViewResult
            {
                ViewName = "_Create",
                ViewData = new ViewDataDictionary<CreateLegendViewModel>(ViewData, legend)
            };
        }
    }
}
