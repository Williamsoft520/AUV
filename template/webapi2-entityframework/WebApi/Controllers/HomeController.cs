using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApi.Controllers
{
    using Services;
    using Data;
    public class HomeController:ApiController
    {
        public HomeController()
        {

        }

        /* 根据自己实际情况使用相应的 Service
         */

        readonly UniqueIdentifierService _uniqueIdentifierService;
        readonly IdentityService _identityService;
        readonly CustomService _customService;

        public HomeController(UniqueIdentifierService uniqueIdentifierService,
            IdentityService identityService,
            CustomService customService)
        {
            this._customService = customService;
            this._identityService = identityService;
            this._uniqueIdentifierService = uniqueIdentifierService;
        }

        public IHttpActionResult Index() => Ok();
    }
}