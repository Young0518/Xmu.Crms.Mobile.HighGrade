using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace Xmu.Crms.HighGrade
{
    public class seminarController : Controller
    {
        public ActionResult Seminar()
        {
            return View ();
        }
        public ActionResult FixedGroupInfoUI()
        {
            return View();
        }
        public ActionResult GradePresentationUI()
        {
            return View();
        }
        public ActionResult GroupInfoUI2()
        {
            return View();
        }
        public ActionResult StudentRollCallUI()
        {
            return View();
        }
        public ActionResult StudentRollCallEndUI()
        {
            return View();
        }
        public ActionResult Score()
        {
            return View();
        }
    }
}
