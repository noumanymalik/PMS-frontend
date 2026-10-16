using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PMS.UI.Models.ViewModels.Attendance;

namespace PMS.UI.Pages.Attendance
{
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> _logger;
        public CreateModel(ILogger<CreateModel> logger)
        {
            _logger = logger;
        }
        [BindProperty]
        public CreateAttendanceViewModel Attendance { get; set; } = default!;
    }
}
