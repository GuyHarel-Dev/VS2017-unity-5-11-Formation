﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnityFormation.ClassesTutor;

namespace UnityFormation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyService _myService;

        public HomeController(IMyService myService)
        {
            _myService = myService;
        }

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}