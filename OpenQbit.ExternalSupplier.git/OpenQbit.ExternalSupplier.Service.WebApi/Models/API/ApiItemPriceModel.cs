using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.ExternalSupplier.Service.WebApi.Models.API
{
    public class ApiItemPriceModel
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public double UnitPrice { get; set; }
        public DateTime Date { get; set; }
        public virtual ApiItemModel item { get; set; }
    }
}