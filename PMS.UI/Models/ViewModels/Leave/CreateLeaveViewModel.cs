using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.Leave
{
    public class CreateLeaveViewModel
    {
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime Date { get; set; }

        public string EmployeeName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Leave From")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LeaveFrom { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Leave To")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime LeaveTo { get; set; }

        [Range(1, 16, ErrorMessage = "Select Leave Type")]
        public int LeaveTypeId { get; set; }

        [Required]
        [DisplayName("Reason")]
        [MaxLength(250, ErrorMessage = "The remarks max 250 characters.")]
        public string Reason { get; set; }

    }
}
