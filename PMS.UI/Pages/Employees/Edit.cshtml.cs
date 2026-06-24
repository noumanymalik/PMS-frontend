using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PMS.UI.Models.ViewModels.Employee;

namespace PMS.UI.Pages.Employees
{
    [Authorize]
    public class EditModel : PageModel
    {
        [FromQuery(Name = "Id")]
        public int EmployeeId { get; set; }

        [BindProperty]
        public EditEmployeeViewModel Employee { get; set; } = default!;
        public void OnGet()
        {
        }
    }
}
