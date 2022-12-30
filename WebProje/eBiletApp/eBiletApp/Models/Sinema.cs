using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eBiletApp.Models
{
    public class Sinema
    {
        public int SinemaId { get; set; }
        [Display(Name = "Sinema Logo")]
        public string SinemaFotografi { get; set; }

        [Required(ErrorMessage = "Lütfen sinema adını giriniz!")]
        [Display(Name = "Sinema Adı")]
        public string SinemaAdi { get; set; }

        [Required(ErrorMessage = "Lütfen hakkında alanını tam doldurunuz!")]
        [StringLength(1000, MinimumLength = 5, ErrorMessage = "Hakkında alanı 5 ila 1000 karakter arasında olmalıdır!")]
        [Display(Name = "Sinema Hakkında")]
        public string SinemaHakkinda { get; set; }

        public ICollection<Film> Filmler { get; set; }
    }
}
