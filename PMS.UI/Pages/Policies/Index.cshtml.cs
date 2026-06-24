using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PMS.UI.Pages.Policies
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public IActionResult OnGetHRViewPdf1()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdf/HRPolicy1.pdf");

            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            return File(stream, "application/pdf"); 
        }

        public IActionResult OnGetHRViewPdf2()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdf/HRPolicy2.pdf");

            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            return File(stream, "application/pdf");
        }

        public IActionResult OnGetHRViewPdf3()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdf/HRPolicy3.pdf");

            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            return File(stream, "application/pdf");
        }

        public IActionResult OnGetHRViewPdf4()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdf/HRPolicy4.pdf");

            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            return File(stream, "application/pdf");
        }

        public IActionResult OnGetDownloadPdf()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdf/HRPolicy1.pdf");

            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            Response.Headers.Add("Content-Disposition", "attachment; filename=sample.pdf");

            return File(stream, "application/pdf");
        }
    }
}
