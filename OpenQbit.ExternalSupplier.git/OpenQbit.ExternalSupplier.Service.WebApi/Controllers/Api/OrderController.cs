using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OpenQbit.ExternalSupplier.Service.WebApi.Models.API;

namespace OpenQbit.ExternalSupplier.Service.WebApi.Controllers.Api
{
    public class OrderController : ApiController
    {
        public bool Add(ApiOrderModels order)
        {
            return true;
        }
        public bool update(ApiOrderModels order)
        {
            return true;
        }
        public bool delete(int id)
        {
            
            return true;
        }

    }
}
