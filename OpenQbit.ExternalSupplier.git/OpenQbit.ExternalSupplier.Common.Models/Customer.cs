using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.ExternalSupplier.Common.Models
{
    public class Customer
    {
        public int customerId{ get; set; }
        public string Name{ get; set; }
        public String Address { get; set; }
        public String ContactNo{ get; set; }
        public String Email { get; set; }
        public virtual ICollection<Order> Orders{ get; set; }
    }
}
