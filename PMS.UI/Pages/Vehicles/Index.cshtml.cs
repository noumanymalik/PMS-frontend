using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PMS.UI.Models.ViewModels.Transport;

namespace PMS.UI.Pages.Vehicles
{
    public class IndexModel : PageModel
    {
        public async Task<PartialViewResult> OnGetCreateNewVehicle()
        {
            var vehicle = new CreateVehicleViewModel();
            return new PartialViewResult
            {
                ViewName = "_Create",
                ViewData = new ViewDataDictionary<CreateVehicleViewModel>(ViewData, vehicle)
            };
        }
    }
}
