using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.Department
{
    public class CreateDepartmentViewModel
    {
        [DisplayName("Code")]
        [Required(ErrorMessage = "Enter the department code.")]
        [MinLength(3, ErrorMessage = "The name must contain at least 3 characters.")]
        [MaxLength(50, ErrorMessage = "The name max 50 characters.")]
        public string Code { get; set; }

        [DisplayName("Name")]
        [Required(ErrorMessage = "Enter the department name.")]
        [MinLength(3, ErrorMessage = "The name must contain at least 3 characters.")]
        [MaxLength(50, ErrorMessage = "The name max 50 characters.")]
        public string Name { get; set; }
    }
}
