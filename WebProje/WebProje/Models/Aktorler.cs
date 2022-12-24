using System.ComponentModel.DataAnnotations;

namespace WebProje.Models
{
    public class Aktorler
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profil Fotografi")]
        public string ProfilFotoURL { get; set; }

        [Display(Name = "İsim")]
        public string Isim { get; set; }

        [Display(Name = "Biyografi")]
        public string Biyografi { get; set; }

        public List<Aktor_Film> Aktor_Filmler { get; set; }

    }
}
