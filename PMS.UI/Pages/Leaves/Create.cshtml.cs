using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PMS.UI.Models.ViewModels.Leave;

namespace PMS.UI.Pages.Leaves
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> _logger;
        public CreateModel(ILogger<CreateModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public CreateLeaveViewModel CreateLeave { get; set; } = default!;

    }
}
