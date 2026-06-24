using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.User
{
    public class CreateRoleViewModel
    {
        [DisplayName("Name")]
        [Required(ErrorMessage = "Role name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Enter 3 to 50 characters")]
        public string Name { get; set; }
    }
}
