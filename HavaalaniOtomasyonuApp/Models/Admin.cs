using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HavaalaniOtomasyonuApp.Models
{
    public class Admin
    {
        public int AdminId { get; set; }

        [Display(Name = "Kullanıcı Adı")]
        [Required(ErrorMessage = "Kullanıcı Adı Giriniz", AllowEmptyStrings = false)]

        public string username { get; set; }

        [Display(Name = "Şifre")]
        [Required(ErrorMessage = "Şifre Giriniz", AllowEmptyStrings = false)]
        public string password { get; set; }
    }

}