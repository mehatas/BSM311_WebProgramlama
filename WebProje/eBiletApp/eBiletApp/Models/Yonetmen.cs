using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBiletApp.Models
{
    public class Yonetmen
    {
        public int YonetmenId { get; set; }

        [Display(Name="Fotoğraf")]
        public string YonetmenFotografi { get; set; }

        [Required(ErrorMessage = "Lütfen yönetmen ismi giriniz")]
        [StringLength(40, MinimumLength = 5, ErrorMessage = "Ad Soyad 5 ila 40 karakter arasında olmalıdır!")]
        [Display(Name = "Adı Soyadı")]
        public string YonetmenAdSoyad { get; set; }

        [Required(ErrorMessage = "Lütfen hakkında alanını tam doldurunuz!")]
        [Display(Name = "Hakkında")]
        [StringLength(1000, MinimumLength = 5, ErrorMessage = "Hakkında alanı 5 ila 1000 karakter arasında olmalıdır!")]
        public string YonetmenHakkinda { get; set; }

        public ICollection<Film> Filmler { get; set; }
    }
}
