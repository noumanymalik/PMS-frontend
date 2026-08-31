using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PMS.UI.Models.ViewModels.Transport;

namespace PMS.UI.Pages.TransportShedules
{
    public class IndexModel : PageModel
    {
        public async Task<PartialViewResult> OnGetCreateNewTransportShedule()
        {
            var shedule = new CreateSheduleViewModel();
            return new PartialViewResult
            {
                ViewName = "_Create",
                ViewData = new ViewDataDictionary<CreateSheduleViewModel>(ViewData, shedule)
            };
        }
    }
}
