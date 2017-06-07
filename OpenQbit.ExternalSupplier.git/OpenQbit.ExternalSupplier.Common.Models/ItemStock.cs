using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.ExternalSupplier.Common.Models
{
    public class ItemStock
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public virtual Item items{ get; set; }

    }
}
