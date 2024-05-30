using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SOWRunRegistration.Models
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(100)]
        [MaxLength(100)]
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? EmpNo { get; set; }
    }
}
