using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.Cancellation
{
    public class CreateSalesCancelViewModel
    {
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Create Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime CreateDate { get; set; }

        [Required]
        [DisplayName("QA Notes")]
        [MaxLength(2000, ErrorMessage = "The remarks max 2000 characters.")]
        public string Remarks { get; set; }
    }
}
