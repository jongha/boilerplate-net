﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Resources;
using System.Web;
using System.Web.Mvc;
using Web.Lib.Helpers;

namespace Web.Controllers
{
    public class BaseController : Controller
    {
        public BaseController()
        {
            ViewBag.SiteName = ConfigurationManager.AppSettings["SiteName"].ToString();

            String culture = CultureHelper.GetCurrentCulture();
        }
    }
}