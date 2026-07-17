using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.Employee
{
    public class CreateCorrectiveActionViewModel
    {
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Create Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime CreateDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Incident Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime IncidentDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Valid From Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime ValidFromDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Valid To Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime ValidToDate { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Select Employee")]
        [DisplayName("Employee")]
        public int EmployeeId { get; set; }

        [Range(1, 6, ErrorMessage = "Select Corrective Action")]
        [DisplayName("Action")]
        public int ActionId { get; set; }

        [Range(1, 4, ErrorMessage = "Select Corrective Action Reason")]
        [DisplayName("Reason")]
        public int ReasonId { get; set; }

        [Required]
        [DisplayName("Remarks")]
        [MaxLength(250, ErrorMessage = "The remarks max 250 characters.")]
        public string Remarks { get; set; }

    }
}
