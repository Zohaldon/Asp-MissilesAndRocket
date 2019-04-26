using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PACS.Data.Models;

namespace PACS.ViewModels
{
    public class RocketListViewModel
    {
        public IEnumerable<Rocket> Rockets { get; set; }
        public string CurrentCategory { get; set; }
    }
}
