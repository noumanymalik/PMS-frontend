using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OfficeOpenXml;
using System.Data;

namespace PMS.UI.Pages.Imports
{
    public class CallSummaryInboundModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IWebHostEnvironment _environment;
        public CallSummaryInboundModel(ILogger<IndexModel> logger, IWebHostEnvironment environment)
        {
            _logger = logger;
            _environment = environment;
        }
        public void OnPostUploadAsync(IFormFile postedFile)
        {
            if (postedFile == null)
            {
                throw new Exception("File is NULL");
            }

            string wwwPath = this._environment.WebRootPath;
            string contentPath = this._environment.ContentRootPath;

            string path = Path.Combine(this._environment.WebRootPath, "temp");

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            string fileName = Path.GetFileName(postedFile.FileName);
            using (FileStream stream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            {
                postedFile.CopyTo(stream);

            }
        }

        public JsonResult OnGetLoadData()
        {
            //string filePath = @"D:\Development\Payroll Documents\Book3.xlsx";
            string filePath = _environment.WebRootPath + @"\temp\Call Summary.xlsx";

            DataTable dt = ExcelToDataTable(filePath);

            var data = new List<Dictionary<string, object>>();

            foreach (DataRow row in dt.Rows)
            {
                var dict = new Dictionary<string, object>();
                foreach (DataColumn col in dt.Columns)
                {
                    dict[col.ColumnName] = row[col];
                }
                data.Add(dict);
            }

            return new JsonResult(data);
        }

        public DataTable ExcelToDataTable(string filePath)
        {
            ExcelPackage.License.SetNonCommercialPersonal("Nouman Malik");
            // ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            DataTable dt = new DataTable();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                int rowCount = worksheet.Dimension.Rows;
                int colCount = worksheet.Dimension.Columns;

                // Add columns
                for (int col = 1; col <= colCount; col++)
                {
                    dt.Columns.Add(worksheet.Cells[1, col].Text);
                }

                // Add rows
                for (int row = 2; row <= rowCount; row++)
                {
                    DataRow dr = dt.NewRow();

                    for (int col = 1; col <= colCount; col++)
                    {
                        dr[col - 1] = worksheet.Cells[row, col].Text;
                    }

                    dt.Rows.Add(dr);
                }
            }

            return dt;
        }

    }
}

