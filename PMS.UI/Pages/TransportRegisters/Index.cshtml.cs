using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PMS.UI.Models.ViewModels.Transport;

namespace PMS.UI.Pages.TransportRegisters
{
    public class IndexModel : PageModel
    {
        public async Task<PartialViewResult> OnGetCreateNewTransportRegister()
        {
            var register = new CreateRegisterViewModel();
            return new PartialViewResult
            {
                ViewName = "_Create",
                ViewData = new ViewDataDictionary<CreateRegisterViewModel>(ViewData, register)
            };
        }
    }
}
