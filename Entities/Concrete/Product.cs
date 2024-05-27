using Core.Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : BaseEntity, IEntity
    {
        public string Name { get; set; }
        public int ColorID { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
        public virtual ICollection<WarehouseProductMapping> WarehouseProductMappings { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
