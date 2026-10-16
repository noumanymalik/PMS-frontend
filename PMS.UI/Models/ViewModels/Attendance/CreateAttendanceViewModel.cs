using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.Attendance
{
    public class CreateAttendanceViewModel
    {
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime AttendanceDate { get; set; }

        [Required(ErrorMessage = "Employee is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Employee is required.")]
        public int EmployeeId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Legend is required.")]
        [DisplayName("Legends")]
        public int LegendId { get; set; }
    }
}
