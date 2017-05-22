using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.ExternalSupplier.Common.Models
{
    class OrderDetails
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Discount { get; set; }
        public double Amount { get; set; }
        public int ItemId { get; set; }
        public virtual Item item { get; set; }
        public virtual Order orders{ get; set; }
       

    }
}
