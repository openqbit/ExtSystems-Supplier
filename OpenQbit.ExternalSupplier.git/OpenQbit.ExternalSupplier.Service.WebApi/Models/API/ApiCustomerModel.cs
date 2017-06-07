using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.ExternalSupplier.Service.WebApi.Models.API
{
    public class ApiCustomerModel
    {
        public int customerId { get; set; }
        public string Name { get; set; }
        public String Address { get; set; }
        public String ContactNo { get; set; }
        public String Email { get; set; }
        public virtual ICollection<ApiOrderModels> Orders { get; set; }

    }
}