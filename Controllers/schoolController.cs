using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Xmu.Crms.HighGrade
{
    public class schoolController : Controller
    {
        public ActionResult CreateSchoolUI()
        {
            return View ();
        }
        public ActionResult CreateSchool()
        {
            return View();
        }
        public ActionResult ChooseSchool_province()
        {
            return View();
        }
        public ActionResult ChooseSchool_city()
        {
            return View();
        }
        public ActionResult ChooseSchool_school()
        {
            return View();
        }
    }
}
