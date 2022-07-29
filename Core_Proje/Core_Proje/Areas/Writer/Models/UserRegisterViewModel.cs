using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen Kullanıcı adını giriniz")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Lütfen  adını giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Lütfen ImageUrl giriniz")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Lütfen  soyadını giriniz")]
        public string SurName { get; set; }
        [Required(ErrorMessage = "Lütfen şifreyi giriniz")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifre tekrar giriniz")]
        [Compare("Password", ErrorMessage ="şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen mail giriniz")]
        public string Mail { get; set; }
    }
}
