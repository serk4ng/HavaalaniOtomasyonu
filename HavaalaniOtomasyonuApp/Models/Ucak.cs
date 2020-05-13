using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HavaalaniOtomasyonuApp.Models
{
    public class Ucak
    {
        public int UcakId { get; set; }

        [Display(Name = "Uçak Adı")]
        [Required(ErrorMessage = "Uçak Adı Giriniz", AllowEmptyStrings = false)]
        public string Ucak_Adi { get; set; }

        [Display(Name = "Kapasite")]
        [Required(ErrorMessage = "Kapasite Giriniz", AllowEmptyStrings = false)]
        public int Kapasite { get; set; }
    }
}