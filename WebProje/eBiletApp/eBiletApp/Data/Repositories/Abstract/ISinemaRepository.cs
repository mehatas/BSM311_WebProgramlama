using eBiletApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eBiletApp.Data.Repositories.Abstract
{
    public interface ISinemaRepository
    {
        Sinema GetById(int id);
        void Add(Sinema sinema);
        void Delete(int id);
        Sinema Update(int id, Sinema sinemaSon);
        Task<IEnumerable<Sinema>> ListAll();
    }
}
