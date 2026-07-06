using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PMS.UI.Models.ViewModels.Employee;

namespace PMS.UI.Pages.CorrectiveActions
{
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> _logger;
        public CreateModel(ILogger<CreateModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public CreateCorrectiveActionViewModel CorrectiveAction { get; set; } = default!;
    }
}
