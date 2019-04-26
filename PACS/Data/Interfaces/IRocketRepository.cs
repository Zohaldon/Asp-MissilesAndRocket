using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PACS.Data.Models;

namespace PACS.Data.Interfaces
{
    public interface IRocketRepository
    {
        IEnumerable<Rocket> Rockets { get; }
        IEnumerable<Rocket> PreferredRockets { get; }
        Rocket GetRocketById(int rocketId);
    }
}
