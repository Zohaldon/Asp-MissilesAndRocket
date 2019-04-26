using PACS.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PACS.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Rocket> PreferredRockets { get; set; }
    }
}
