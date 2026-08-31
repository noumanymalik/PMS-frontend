using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.Transport
{
    public class CreateSheduleViewModel
    {
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Create Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime CreateDate { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Select Employee")]
        [DisplayName("Employee")]
        public int EmployeeId { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Select Vehicle")]
        [DisplayName("Vehicle")]
        public int VehicleId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Start Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime StartDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("End Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime EndDate { get; set; }

    }
}
