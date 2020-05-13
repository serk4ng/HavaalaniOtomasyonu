using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HavaalaniOtomasyonuApp.Areas.admin.Models
{
    public class LoginModel
    {
        [Display(Name = "Username : ")]
        [Required(ErrorMessage = "Kullanıcı Adı Giriniz!", AllowEmptyStrings = false)]
        public string username { get; set; }

        [Display(Name = "Password : ")]
        [Required(ErrorMessage = "Şifre Giriniz!", AllowEmptyStrings = false)]
        [DataType(DataType.Password)]   
        public string password { get; set; }
    }
}