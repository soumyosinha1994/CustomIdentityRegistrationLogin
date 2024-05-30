using System.ComponentModel.DataAnnotations;

namespace SOWRunRegistration.Models
{
    public class Employee
    {
        [Required]
        public string? EmpNo { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords don't match.")]
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }
    }
}
