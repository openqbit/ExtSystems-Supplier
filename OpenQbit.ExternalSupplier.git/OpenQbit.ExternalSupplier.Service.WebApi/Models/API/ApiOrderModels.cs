using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.ExternalSupplier.Service.WebApi.Models.API
{
    public class ApiOrderModels
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }

        public int CustomerId { get; set; }
        public virtual ApiCustomerModel Customer { get; set; }
        public virtual ICollection<ApiOrderDetailsModel> Orderdetails { get; set; }
    }
}