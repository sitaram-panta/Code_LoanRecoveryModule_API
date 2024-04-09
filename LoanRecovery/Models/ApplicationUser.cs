using LoanRecovery.Enums;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LoanRecovery.Migrations.Models
{
    public class ApplicationUser : IdentityUser
    {
        //[MaxLength(255)]
        //public string FirstName { get; set; } = string.Empty;

        //[MaxLength(255)]
        //public string LastName { get; set; } = string.Empty;
        [Required]
        public EnumApplicationUserType UserType { get; set; }

    }
}
