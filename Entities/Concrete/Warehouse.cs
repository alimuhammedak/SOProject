using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Warehouse : BaseEntity, IEntity
    {
        public int ProductId { get; set; }
        public int Piece { get; set; }
        public bool ReadyForSale { get; set; }
        public virtual ICollection<WarehouseProductMapping> WarehouseProductMappings { get; set; }
        public virtual Product Product { get; set; }
    }
}
