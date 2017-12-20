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
    public class courseController : Controller
    {
        public ActionResult ClassManage(){
            return View();
        }
        public ActionResult CourseInfoUI()
        {
            return View();
        }
        public ActionResult CourseUI()
        {
            return View();
        }
    }

}