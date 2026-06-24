using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.Employee
{
    public class EditEmployeeViewModel
    {
        [Required(ErrorMessage = "Employee Id is required.")]
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Create Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime CreateDate { get; set; }

        [Required(ErrorMessage = "Employee Code is required.")]
        [DisplayName("Code")]
        public string Code { get; set; } = null!;

        [Required(ErrorMessage = "Employee Name is required.")]
        [DisplayName("Name")]
        public string Name { get; set; } = null!;

        [DisplayName("Supervisor")]
        public int? SupervisorId { get; set; }

        [Required(ErrorMessage = "Department is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Department is required.")]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Designation is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Designation is required.")]
        [DisplayName("Designation")]
        public int DesignationId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Joining Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime JoiningDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Leaving Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime? LeavingDate { get; set; }

        public int JobStatusId { get; set; }
        public int StatusId { get; set; }
        public int GenderId { get; set; }

        [DisplayName("Phone No 1")]
        [RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{7})$", ErrorMessage = "Phone must follow the 03001234567 format.")]
        public string? PhoneNo1 { get; set; } = null!;

        [DisplayName("Phone No 1")]
        [RegularExpression(@"^\(?([0-9]{4})\)?[-. ]?([0-9]{7})$", ErrorMessage = "Phone must follow the 03001234567 format.")]
        public string? PhoneNo2 { get; set; }

        [DisplayName("Email Address")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Enter 3 to 50 characters")]
        public string? EmailAddressCompany { get; set; } = null!;

        [DisplayName("Email Address Personal")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Enter 3 to 50 characters")]
        public string? EmailAddressPersonal { get; set; }

        [DisplayName("Next Of Kin")]
        [MaxLength(50, ErrorMessage = "The fiels max contain 50 characters.")]
        public string? NextOfKin { get; set; }

        [DisplayName("Bank Name")]
        [MaxLength(50, ErrorMessage = "The fiels max contain 50 characters.")]
        public string? BankName { get; set; }

        [DisplayName("Account Tittle")]
        [MaxLength(50, ErrorMessage = "The fiels max contain 50 characters.")]
        public string? AccountTittle { get; set; }

        [DisplayName("Bank Account No")]
        [MaxLength(50, ErrorMessage = "The fiels max contain 50 characters.")]
        public string? BankAccountNo { get; set; }

        [DisplayName("IBAN")]
        [MaxLength(10, ErrorMessage = "The fiels max contain 10 characters.")]
        public string? IBAN { get; set; }

        [DisplayName("Basic Salary")]
        public decimal BasicSalary { get; set; }

        [DisplayName("KPI")]
        public decimal KPI { get; set; }

        [DisplayName("Incentive")]
        public decimal Incentive { get; set; }

        [DisplayName("Salary Type")]
        public int SalaryTypeId { get; set; }

        [DisplayName("CNIC No")]
        [RegularExpression(@"^\d{5}-\d{7}-\d{1}$", ErrorMessage = "Phone must follow the 12345-1234567-1 format.")]
        public string? CNICNo { get; set; } = null!;

        [DisplayName("Full Name")]
        [MaxLength(50, ErrorMessage = "The fiels max contain 50 characters.")]
        public string? FullName { get; set; } = null!;

        [DisplayName("Father Or HusbandName")]
        [MaxLength(50, ErrorMessage = "The fiels max contain 50 characters.")]
        public string? FatherOrHusbandName { get; set; } = null!;

        [MaxLength(50, ErrorMessage = "The fiels max contain 50 characters.")]
        [DisplayName("Family No")]
        public string? FamilyNo { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date Of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime DateOfBirth { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date Of Issue")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime DateOfIssue { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date Of Expiry")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime DateOfExpiry { get; set; }

        [DisplayName("Existing Address")]
        public string? ExistingAddress { get; set; } = null!;

        [DisplayName("Permanent Address")]
        public string? PermanentAddress { get; set; } = null!;
    }
}
