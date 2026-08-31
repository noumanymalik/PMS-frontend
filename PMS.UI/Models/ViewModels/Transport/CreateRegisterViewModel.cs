using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.Transport
{
    public class CreateRegisterViewModel
    {
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Create Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime CreateDate { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Select Vehicle")]
        [DisplayName("Vehicle")]
        public int VehicleId { get; set; }

        [Required]
        [DisplayName("Time In")]
        [DataType(DataType.Time)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = @"{0:hh\:mm}")]
        public string TimeIn { get; set; }

    }
}
