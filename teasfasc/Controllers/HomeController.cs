using DentApexis.BLL.Repository;
using DentApexis.MODEL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace teasfasc.Controllers
{
    public class HomeController : Controller
    {

        OnlineAppointmentRepository or = new OnlineAppointmentRepository();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OnlineAppointment()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OnlineAppointment(OnlineAppointment onlineAppointment)
        {
            or.Insert(onlineAppointment);
            return RedirectToAction("Index", "Home");
        }

        public ActionResult Doctors()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }


    }
}