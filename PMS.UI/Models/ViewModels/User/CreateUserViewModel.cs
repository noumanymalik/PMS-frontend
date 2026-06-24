using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.User
{
    public class CreateUserViewModel
    {
        [DisplayName("Email Address")]
        [Required(ErrorMessage = "Email address is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Enter 3 to 50 characters")]
        public string Email { get; set; }

        [Required]
        [DisplayName("Employee")]
        [Range(1, int.MaxValue, ErrorMessage = "Employee is required.")]
        public int EmployeeId { get; set; }


        [DisplayName("First Name")]
        [Required(ErrorMessage = "First name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Enter 3 to 50 characters")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Enter 3 to 50 characters")]
        public string LastName { get; set; }

        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Enter 3 to 20 characters")]
        public string Password { get; set; }

        [DisplayName("Confirm Password")]
        [Required(ErrorMessage = "Confirmation Password is required.")]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Enter 3 to 20 characters")]
        public string ConfirmPassword { get; set; }

        [DisplayName("User Role")]
        [Range(1, int.MaxValue, ErrorMessage = "User role is required.")]
        public int RoleId { get; set; }
    }
}
