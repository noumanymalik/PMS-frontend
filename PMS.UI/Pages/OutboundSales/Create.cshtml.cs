using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PMS.UI.Models.ViewModels.OutboundSales;

namespace PMS.UI.Pages.OutboundSales
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
        public CreateOutboundSalesViewModel CreateSales { get; set; } = default!;
    }
}
