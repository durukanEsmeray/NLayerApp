using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; } // bu CategoryId, Product entity si için bir ForeignKey dir.

        public Category Category { get; set; } // her bir product un 1 kategorisi vardır.

        public ProductFeature ProductFeature { get; set; }
    }
}
