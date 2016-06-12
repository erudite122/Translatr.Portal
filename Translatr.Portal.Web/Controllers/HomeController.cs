﻿using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Translatr.Portal.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PortalControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}