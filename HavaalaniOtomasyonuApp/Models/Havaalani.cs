using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HavaalaniOtomasyonuApp.Models
{
    public class Havaalani
    {
        public int HavaalaniId { get; set; }

        [Display(Name = "Havaalanı Adı")]
        [Required(ErrorMessage = "Havaalanı Adı Giriniz", AllowEmptyStrings = false)]
        public string Havaalani_Adi { get; set; }

        [Display(Name = "Havaalanı Kodu")]
        [Required(ErrorMessage = "Havaalanı Kodu Giriniz", AllowEmptyStrings = false)]
        public string Havaalani_Kodu { get; set; }
    }
}