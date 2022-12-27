using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiletApp.Models
{
    public class Sepet
    {
        public int SepetId { get; set; }
        public int Adet { get; set; }
        public Film Film { get; set; }

        public string SepetNo { get; set; }
    }
}
