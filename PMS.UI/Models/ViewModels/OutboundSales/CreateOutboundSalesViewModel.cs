using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.OutboundSales
{
    public class CreateOutboundSalesViewModel
    {
        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Date")]
        [DisplayFormat(ApplyFormatInEditMode = false, DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime Date { get; set; }

        public int EmployeeId { get; set; }

        [Required]
        [DisplayName("Customer Name")]
        [MaxLength(50, ErrorMessage = "The customer name max 50 characters.")]
        public string CustomerName { get; set; }

        [Required]
        [DisplayName("Customer Phone No")]
        [MaxLength(10, ErrorMessage = "The customer phone No max 10 characters.")]
        [MinLength(10, ErrorMessage = "The customer phone No min 10 characters.")]
        public string CustomerPhoneNo { get; set; }

        [Required]
        [DisplayName("Confirmation No")]
        [MaxLength(50, ErrorMessage = "The sales confirmation No max 50 characters.")]
        public string ConfirmationNo { get; set; }

        [Required]
        [DisplayName("Product Sold")]
        public int ProductId { get; set; }

        [Required]
        [DisplayName("RGUs")]
        public int Quantity { get; set; }

        [Required]
        [DisplayName("Closed By")]
        public int CloserId { get; set; }
    }
}
