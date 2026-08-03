using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PMS.UI.Models.ViewModels.Cancellation;

namespace PMS.UI.Pages.Cancellation
{
    public class IndexModel : PageModel
    {
        public async Task<PartialViewResult> OnGetCreateCancellationAsync(int id)
        {
            var cancel = new CreateSalesCancelViewModel 
            { 
                Id = id,
                CreateDate = DateTime.Today
            };
            return new PartialViewResult
            {
                ViewName = "_Create",
                ViewData = new ViewDataDictionary<CreateSalesCancelViewModel>(ViewData, cancel)
            };
        }
    }
}
