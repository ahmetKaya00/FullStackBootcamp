using System.ComponentModel.DataAnnotations;

namespace UserIdentityApp.ViewModels
{
    public class ResetPasswordModel{
        [Required]
        public string Token{get;set;} = string.Empty;

         [Required]
         [DataType(DataType.EmailAddress)]
        public string Email{get;set;} = string.Empty;

         [Required]
         [DataType(DataType.Password)]
        public string Password{get;set;} = string.Empty;

         [Required]
         [DataType(DataType.Password)]
         [Compare(nameof(Password),ErrorMessage ="Parola Eşleşmiyor.")]
        public string ConfirmPassword{get;set;} = string.Empty;
    }
}