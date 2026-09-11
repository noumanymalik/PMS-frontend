using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.Attendance
{
    public class CreateLegendViewModel
    {
        [DisplayName("Code")]
        [Required(ErrorMessage = "Enter the legend code.")]
        [MinLength(3, ErrorMessage = "The name must contain at least 3 characters.")]
        [MaxLength(50, ErrorMessage = "The name max 50 characters.")]
        public string Code { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Enter the legend name.")]
        [MinLength(3, ErrorMessage = "The name must contain at least 3 characters.")]
        [MaxLength(50, ErrorMessage = "The name max 50 characters.")]
        public string Name { get; set; }

        [DisplayName("Description")]
        [Required(ErrorMessage = "Enter the description.")]
        [MinLength(3, ErrorMessage = "The name must contain at least 3 characters.")]
        [MaxLength(50, ErrorMessage = "The name max 50 characters.")]
        public string Description { get; set; }
    }
}
