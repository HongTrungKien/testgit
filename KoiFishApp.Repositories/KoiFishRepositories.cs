using KoiFishApp.Repositories.Entities;
using KoiFishApp.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace KoiFishApp.Repositories
{
    public class KoiFishRepositories : IKoiFishRepositories
    {
        private readonly QlcktnContext _DbContext;
        public KoiFishRepositories(QlcktnContext DbContext)
        {
            _DbContext = DbContext;
        }
        public async Task<List<KoiFish>> GetAllKoiFish()
        {
            return await _DbContext.KoiFishes.ToListAsync();
        }
    }
}
