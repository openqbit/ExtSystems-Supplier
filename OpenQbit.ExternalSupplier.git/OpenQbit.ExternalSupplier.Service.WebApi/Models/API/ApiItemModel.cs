using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.ExternalSupplier.Service.WebApi.Models.API
{
    public class ApiItemModel
    {

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Quntity { get; set; }
        public virtual ICollection<ApiOrderModels> orders { get; set; }
    }
}