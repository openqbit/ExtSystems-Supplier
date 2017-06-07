using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.ExternalSupplier.Service.WebApi.Models.API
{
    public class ApiItemStockModel
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int Quantity { get; set; }
        public virtual ApiItemModel items { get; set; }
    }
}