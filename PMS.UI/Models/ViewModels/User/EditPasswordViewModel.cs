using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.User
{
    public class EditPasswordViewModel
    {
        [DisplayName("Email Address")]
        [Required(ErrorMessage = "Email address is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Enter 3 to 50 characters")]
        public string Email { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Enter 3 to 20 characters")]
        public string Password { get; set; }

        [DisplayName("New Password")]
        [Required(ErrorMessage = "New Password is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Enter 3 to 20 characters")]
        public string NewPassword { get; set; }

        [DisplayName("Confirm New Password")]
        [Required(ErrorMessage = "Confirm New Password is required.")]
        [Compare("NewPassword", ErrorMessage = "New Password and Confirmation Password must match.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Enter 3 to 20 characters")]
        public string ConfirmNewPassword { get; set; }
    }
}
