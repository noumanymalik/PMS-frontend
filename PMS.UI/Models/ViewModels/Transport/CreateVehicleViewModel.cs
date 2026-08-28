using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.Transport
{
    public class CreateVehicleViewModel
    {
        [DisplayName("Registration No")]
        [Required(ErrorMessage = "Enter the vehicle registraton No.")]
        [MinLength(3, ErrorMessage = "The name must contain at least 3 characters.")]
        [MaxLength(50, ErrorMessage = "The name max 50 characters.")]
        public string RegistrationNo { get; set; }

        [DisplayName("Engin No")]
        [Required(ErrorMessage = "Enter the vehicle engin No.")]
        [MinLength(3, ErrorMessage = "The name must contain at least 3 characters.")]
        [MaxLength(50, ErrorMessage = "The name max 50 characters.")]
        public string EnginNo { get; set; }

        [DisplayName("Chassis No")]
        [Required(ErrorMessage = "Enter the vehicle chassis No.")]
        [MinLength(3, ErrorMessage = "The name must contain at least 3 characters.")]
        [MaxLength(50, ErrorMessage = "The name max 50 characters.")]
        public string ChassisNo { get; set; }

        [DisplayName("Make")]
        [Required(ErrorMessage = "Enter the vehicle Make.")]
        [MinLength(3, ErrorMessage = "The name must contain at least 3 characters.")]
        [MaxLength(50, ErrorMessage = "The name max 50 characters.")]
        public string Make { get; set; }

        [DisplayName("Color")]
        [Required(ErrorMessage = "Enter the vehicle color.")]
        [MinLength(3, ErrorMessage = "The name must contain at least 3 characters.")]
        [MaxLength(50, ErrorMessage = "The name max 50 characters.")]
        public string Color { get; set; }

        [DisplayName("Driver Name")]
        [Required(ErrorMessage = "Enter the driver name.")]
        [MinLength(3, ErrorMessage = "The name must contain at least 3 characters.")]
        [MaxLength(50, ErrorMessage = "The name max 50 characters.")]
        public string DriverName { get; set; }
    }
}
