using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgrenExamProject.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Kullanıcı adı giriniz")]
        [Display(Name = "Kullanıcı Adı")]
        
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre giriniz")]
        [Display(Name = "Şifre")]
     
        public string Password { get; set; }
    }
}
