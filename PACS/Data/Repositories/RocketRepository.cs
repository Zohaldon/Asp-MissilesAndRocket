using Microsoft.EntityFrameworkCore;
using PACS.Data.Interfaces;
using PACS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PACS.Data.Repositories
{
    public class RocketRepository : IRocketRepository
    {
        private readonly AppDbContext _appDbContext;
        public RocketRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Rocket> Rockets => _appDbContext.Rockets.Include(c => c.Category);

        public IEnumerable<Rocket> PreferredRockets => _appDbContext.Rockets.Where(p => p.IsPreferredRocket).Include(c => c.Category);

        public Rocket GetRocketById(int rocketId) => _appDbContext.Rockets.FirstOrDefault(p => p.RocketId == rocketId);
    }
}
