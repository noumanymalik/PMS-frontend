using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PMS.UI.Pages.Authentication
{
    public class LogoutModel : PageModel
    {
        public async Task<IActionResult> OnGetAsync()
        {
            await HttpContext.SignOutAsync();
            HttpContext.Session.SetString("API_Token", "");

            HttpContext.Session.SetString("User_Management", "");
            HttpContext.Session.SetString("Application_Users", "");
            HttpContext.Session.SetString("User_Roles", "");
            HttpContext.Session.SetString("User_Permissions", "");
            HttpContext.Session.SetString("Change_Password", "");

            HttpContext.Session.SetString("Administration", "");
            HttpContext.Session.SetString("Team_Structure", "");
            HttpContext.Session.SetString("Add_New_Employee", "");
            HttpContext.Session.SetString("View_Employee_Detail", "");
            HttpContext.Session.SetString("Edit_Employee_Information", "");

            HttpContext.Session.SetString("Department", "");
            HttpContext.Session.SetString("Add_New_Department", "");

            HttpContext.Session.SetString("Designation", "");
            HttpContext.Session.SetString("Add_New_Designation", "");

            HttpContext.Session.SetString("Organizational_Chart", "");
            HttpContext.Session.SetString("Corrective_Action", "");

            HttpContext.Session.SetString("Leave", "");
            HttpContext.Session.SetString("Apply_Leave", "");
            HttpContext.Session.SetString("Leave_Status", "");
            HttpContext.Session.SetString("Team_Pending_Leaves", "");

            HttpContext.Session.SetString("Team_Approved_Leaves", "");
            HttpContext.Session.SetString("Polices", "");
            HttpContext.Session.SetString("Policiy_Documents", "");
            HttpContext.Session.SetString("Score_Card", "");
            HttpContext.Session.SetString("Score_Card_Documents", "");

            HttpContext.Session.SetString("Loan", "");
            HttpContext.Session.SetString("Loan_Request", "");
            HttpContext.Session.SetString("Loan_Status", "");
            HttpContext.Session.SetString("Team_Pending_Loan", "");
            HttpContext.Session.SetString("Final_Pending_Loan", "");
            HttpContext.Session.SetString("Released_Approved_Loan", "");

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToPage("/Authentication/Login");
        }
    }
}
