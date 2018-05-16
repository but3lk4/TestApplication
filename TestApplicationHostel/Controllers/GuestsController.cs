using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApplicationHostel.Models;

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
            var guests = _context.Guests.ToList();
            {
                return View(guests);
            }
        }
       
    }
}