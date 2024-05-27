using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class WarehouseProductMapping:BaseEntity,IEntity
    {
        public int ProductId { get; set; }
        public int WarehouseId { get; set; }
        public int Quentity { get; set; }
        public bool ReadyForSale { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        public virtual Product Product { get; set; }

    }
}
