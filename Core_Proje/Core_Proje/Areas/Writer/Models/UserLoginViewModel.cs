using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.Writer.Models
{
    public class UserLoginViewModel
    {
        [Display(Name ="Kullanıcı Adı")]
        [Required(ErrorMessage ="Kullanıcı adını giriniz")]
        public string Surname { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre  giriniz")]
        public string Password { get; set; }
    }
}
