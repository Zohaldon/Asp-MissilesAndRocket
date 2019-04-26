using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PACS.Data.Models;
using PACS.Data.Interfaces;

namespace PACS.Data.Mocks
{
    public class MockRocketRepository : IRocketRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Rocket> PreferredRockets { get; set; }

        public Rocket GetRocketById(int rocketId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Rocket> Rockets
        {
            get
            {
                return new List<Rocket>
                {
                    new Rocket {
                        Name = "Falcon heavy",
                        Price = 1200000005M, ShortDescription = "Get your orbital satellite launched",
                        LongDescription = "Falcon Heavy is the most powerful operational rocket in the world by a factor of two. With the ability to lift into orbit nearly 64 metric tons",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "../Images/",
                        InStock = 10,
                        IsPreferredRocket = true,
                        ImageThumbnailUrl = "../Images/fht.jpg"
                    },
                    new Rocket {
                        Name = "BFR",
                        Price = 654897000005M, ShortDescription = "Lets aim towards the planet mars.",
                        LongDescription = "BFR is a fully reusable vehicle designed to service all Earth orbit needs as well as the Moon and Mars.",
                        Category = _categoryRepository.Categories.First(),
                        ImageUrl = "../Images/",
                        InStock = 5,
                        IsPreferredRocket = true,
                        ImageThumbnailUrl = "../Images/bfrt.jpg"
                    },
                    new Rocket {
                        Name = "PSlV",
                        Price = 89652000005M, ShortDescription = "the indian engine",
                        LongDescription = "Polar Satellite Launch Vehicle (PSLV) is the third generation launch vehicle of ... The third stage of PSLV is a solid rocket motor that provides the upper stages",
                        Category = _categoryRepository.Categories.Last(),
                        ImageUrl = "../Images/",
                        InStock = 1,
                        IsPreferredRocket = true,
                        ImageThumbnailUrl = "../Images/pslvt.jpg"
                    }
                };
            }

            set
            {
            }
        }
    }
}
