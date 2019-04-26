using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PACS.Data.Models
{
    public class Rocket
    {
        public int RocketId { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPreferredRocket { get; set; }
        public int InStock { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
