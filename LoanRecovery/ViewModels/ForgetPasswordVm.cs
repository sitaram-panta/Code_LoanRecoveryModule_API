using System.ComponentModel.DataAnnotations;

namespace LoanRecovery.ViewModels
{
    public class ForgetPasswordVm
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
