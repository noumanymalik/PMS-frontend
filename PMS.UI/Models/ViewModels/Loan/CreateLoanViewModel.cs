using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.Loan
{
    public class CreateLoanViewModel
    {
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime Date { get; set; }

        public int EmployeeId { get; set; }

        [Range(1, 4, ErrorMessage = "Select No of Installments")]
        [DisplayName("Installments")]
        public int InstallmentId { get; set; }

        [Required]
        [DisplayName("Amount")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "Amount must be a valid number.")]
        public decimal Amount { get; set; }

        [Required]
        [DisplayName("Reason")]
        [MaxLength(250, ErrorMessage = "The remarks max 250 characters.")]
        public string Reason { get; set; }
    }
}
