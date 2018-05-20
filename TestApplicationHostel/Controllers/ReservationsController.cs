using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApplicationHostel.Models;

namespace TestApplicationHostel.Controllers
{
    public class ReservationsController : Controller
    {
        // GET: Reservation

        private ApplicationDbContext _context;
        public ReservationsController ()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
           _context.Dispose();
        }
        
        public ViewResult Index()
        {
            var reservations = _context.Reservations.ToList();
            {
                return View(reservations);
            }
        }
        public ActionResult Details(int id)
        {
            var reservations = _context.Reservations.SingleOrDefault(r => r.ID == id);

            if (reservations == null)
                return HttpNotFound();

            return View(reservations);

        }
    }
}