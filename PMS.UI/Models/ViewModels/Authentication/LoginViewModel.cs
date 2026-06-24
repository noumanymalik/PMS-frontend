using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.Authentication
{
    [ValidateAntiForgeryToken]
    public class LoginViewModel
    {
        [DisplayName("Email")]
        [Required(ErrorMessage = "Enter the Email Address.")]
        [MinLength(3, ErrorMessage = "The name must contain at least 3 characters.")]
        [MaxLength(50, ErrorMessage = "The name maximum 50 characters.")]
        public required string Email { get; set; }

        [PasswordPropertyText]
        public required string Password { get; set; }
    }
}
