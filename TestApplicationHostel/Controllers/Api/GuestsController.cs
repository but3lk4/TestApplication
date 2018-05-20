using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApplicationHostel.Models;

namespace TestApplicationHostel.Controllers.Api
{
    public class GuestsController : ApiController
    {
        private ApplicationDbContext _context;

        public GuestsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET/ all reservations
        public IEnumerable<Guest> GetGuests()
        {
            return _context.Guests.ToList();
        }

        public Guest GetGuestPiotr(string name, string city)
        {
            var guest = _context.Guests.SingleOrDefault(g => g.Name == "Piotr" & g.City == " Wrocław" );

            return guest;
        }
        [HttpPut]
        public void UpdateGuest(int id, Guest guest)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var guestInDataBase = _context.Guests.SingleOrDefault(g => g.ID == id);

            if (guestInDataBase == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            guestInDataBase.Name = guest.Name;
            guestInDataBase.SurName = guest.SurName;
            guestInDataBase.ID = guest.ID;
            guestInDataBase.DateOfBirth = guest.DateOfBirth;
            guestInDataBase.EMail = guest.EMail;
            guestInDataBase.PhoneNumber = guest.PhoneNumber;
            guestInDataBase.City = guest.City;
            guestInDataBase.Address = guest.Address;
            guestInDataBase.ZipCode = guest.ZipCode;
            

            _context.SaveChanges();

        }



    }
}
