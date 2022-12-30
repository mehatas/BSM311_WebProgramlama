using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiletApp.Models
{
    public class FilmOyuncu
    {

        public int OyuncuId  { get; set; }
        public int FilmId { get; set; }

        public Oyuncu Oyuncu { get; set; }
        public Film Film { get; set; }

    }
}
