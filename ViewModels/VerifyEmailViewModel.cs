using System.ComponentModel.DataAnnotations;

namespace SalesCRMApp.ViewModels
{
    public class VerifyEmailViewModel
    {


        [Required(ErrorMessage = "Email is required")]
        [EmailAddress]
        public string Email { get; set; }
    }
}
