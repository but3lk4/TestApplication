using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApplicationHostel.Models;
using System.Data.Entity;


namespace TestApplicationHostel.Controllers
{
    public class GuestsController : Controller
    {
        // GET: Guest

        private ApplicationDbContext _context;
        public GuestsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            var guests = _context.Guests.Include(g => g.Reservation).ToList();
            {
                return View(guests);
            }
        }

        public ActionResult Details(int id)
        {
            var guests = _context.Guests.SingleOrDefault(g => g.ID == id);

            if (guests == null)
                return HttpNotFound();

            return View(guests);
        }
       
    }
}