using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using OpenQbit.ExternalSupplier.Service.WebApi.Models.API;

namespace OpenQbit.ExternalSupplier.Service.WebApi.Controllers.Api
{
    public class ItemController : ApiController
    {
        public bool Add(ApiItemModel item)
        {
            return true;
        }
        public bool update(ApiItemModel item)
        {
            return true;
        }
        public bool delete(int id)
        {
            return true;
        }

    }
}
