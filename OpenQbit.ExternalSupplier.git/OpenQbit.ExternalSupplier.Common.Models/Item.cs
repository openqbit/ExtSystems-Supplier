using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.ExternalSupplier.Common.Models
{
    public class Item
    {
       
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quntity { get; set; }
        public virtual ICollection<Order> orders{ get; set; }

    }
}
