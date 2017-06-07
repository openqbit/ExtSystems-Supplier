using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.ExternalSupplier.Service.WebApi.Models.API
{
    public class ApiOrderDetailsModel
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int Discount { get; set; }
        public double Amount { get; set; }
        public int ItemId { get; set; }
        public virtual ApiItemModel item { get; set; }
        public virtual ApiOrderModels orders { get; set; }
    }
}