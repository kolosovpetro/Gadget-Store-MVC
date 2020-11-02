using System.ComponentModel.DataAnnotations;

namespace GadgetStoreMVC.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
 
        [Required]
        [Display(Name = "Year of birth")]
        public int Year { get; set; }
 
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
 
        [Required]
        [Compare("Password", ErrorMessage = "Passwords doesn't match")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm")]
        public string PasswordConfirm { get; set; }
    }
}
