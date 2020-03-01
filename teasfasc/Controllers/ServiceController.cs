using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace teasfasc.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ortodonti()
        {
            return View();
        }
        
        public ActionResult Cer()
        {
            return View();
        }
        public ActionResult Endodonti()
        {
            return View();
        }
        public ActionResult Implantoloji()
        {
            return View();
        }
    }
}