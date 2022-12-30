using eBiletApp.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiletApp.Models.ViewModels
{
    public class SepetVM
    {
        public double ToplamTutar { get; set; }
        public SepetRepository SepetRepo { get; set; }
    }

}
