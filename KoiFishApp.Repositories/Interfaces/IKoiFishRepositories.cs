
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoiFishApp.Repositories.Entities;
namespace KoiFishApp.Repositories.Interfaces
{
    public interface IKoiFishRepositories
    {
        Task<List<KoiFish>> GetAllKoiFish();
    }
}
