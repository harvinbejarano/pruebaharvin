﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.App.Controllers
{
    public class HomeController : Controller
    {
        public RedirectResult Index()
        {
            ViewBag.Title = "Home Page";

            return Redirect("/swagger/ui/index");
        }
    }
}
