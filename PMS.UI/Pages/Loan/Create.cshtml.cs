using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PMS.UI.Models.ViewModels.Loan;

namespace PMS.UI.Pages.Loan
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
        public CreateLoanViewModel CreateLoan { get; set; } = default!;
    }
}
