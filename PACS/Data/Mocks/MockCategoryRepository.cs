using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PACS.Data.Models;
using PACS.Data.Interfaces;

namespace PACS.Data.Mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
                {
                    new Category { CategoryName = "Soild Fueled", Description = "A solid-propellant rocket with a rocket engine that uses solid propellants (fuel/oxidizer)." },
                    new Category { CategoryName = "Liquid Fueled", Description = "A liquid-propellant rocket with a rocket engine that uses liquid propellants." }
                };
            }
        }
    }
}
