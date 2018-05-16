using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestApplicationHostel.Controllers
{
    public class ReservationsController : Controller
    {
        // GET: Reservation
        public ActionResult Index()
        {
            return View();
        }
    }
}