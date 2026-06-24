using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PMS.UI.Models.ViewModels.Employee
{
    public class ViewEmployeeViewModel
    {
        public int Id { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Create Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM-DD-yyyy}")]
        public DateTime CreateDate { get; set; }

        [DisplayName("Code")]
        public string Code { get; set; } = null!;

        [DisplayName("Name")]
        public string Name { get; set; } = null!;

        [DisplayName("Supervisor")]
        public int? SupervisorId { get; set; }

        [DisplayName("Department")]
        public int DepartmentId { get; set; }

        [DisplayName("Designation")]
        public int DesignationId { get; set; }

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
        public string? EmailAddressCompany { get; set; } = null!;

        [DisplayName("Email Address Personal")]
        public string? EmailAddressPersonal { get; set; }

        [DisplayName("Next Of Kin")]
        public string? NextOfKin { get; set; }

        [DisplayName("Bank Name")]
        public string? BankName { get; set; }

        [DisplayName("Account Tittle")]
        public string? AccountTittle { get; set; }

        [DisplayName("Bank Account No")]
        public string? BankAccountNo { get; set; }

        [DisplayName("IBAN")]
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
        public string? CNICNo { get; set; } = null!;

        [DisplayName("Full Name")]
        public string? FullName { get; set; } = null!;

        [DisplayName("Father Or HusbandName")]
        public string? FatherOrHusbandName { get; set; } = null!;

        [DisplayName("Family No")]
        public string? FamilyNo { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Date Of Birth")]
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
