﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace INF272_Deliverable_2.Controllers
{
    public class UserRegistrationController : Controller
    {
        // GET: UserRegistration
        public ActionResult UserRegistration()
        {
            return View();
        }
        public ActionResult FreelancerRegistration()
        {
            return View();
        }
        public ActionResult EmployerReg()
        {
            return View();
        }
    }
}