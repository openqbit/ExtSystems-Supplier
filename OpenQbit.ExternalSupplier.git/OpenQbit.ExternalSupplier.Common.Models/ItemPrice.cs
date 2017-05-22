using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.ExternalSupplier.Common.Models
{
    class ItemPrice
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public double UnitPrice { get; set; }
        public DateTime Date { get; set; }
        public virtual Item item { get; set; }



    }
}
