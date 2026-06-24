using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PMS.UI.Pages.Scorecard
{
    [Authorize]
    public class IndexModel : PageModel
    {
        public IActionResult OnGetSCViewPdf1()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdf/ScoreCard1.pdf");

            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            return File(stream, "application/pdf");
        }

        public IActionResult OnGetSCViewPdf2()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdf/ScoreCard2.pdf");

            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            return File(stream, "application/pdf");
        }

        public IActionResult OnGetSCViewPdf3()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdf/ScoreCard3.pdf");

            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            return File(stream, "application/pdf");
        }

        public IActionResult OnGetSCViewPdf4()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdf/ScoreCard4.pdf");

            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);

            return File(stream, "application/pdf");
        }
    }
}
