using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PACS.Data.Models;

namespace PACS.Data.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
