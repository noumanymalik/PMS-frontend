using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using PMS.UI.Models.ViewModels.Cancellation;

namespace PMS.UI.Pages.Cancellations
{
    public class ApprovalModel : PageModel
    {
        public async Task<PartialViewResult> OnGetViewQANotesAsync(int id)
        {
            var qaNotes = new QaNotesViewModel
            {
                Id = id,
            };
            return new PartialViewResult
            {
                ViewName = "_QaNotes",
                ViewData = new ViewDataDictionary<QaNotesViewModel>(ViewData, qaNotes)
            };
        }
    }
}
