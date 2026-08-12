using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.Report
{
    public class TriumvirateTangoOfTelephonyReportViewModel
    {
        public int ReportTypeId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("From Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime FromDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("To Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime ToDate { get; set; }
    }
}
