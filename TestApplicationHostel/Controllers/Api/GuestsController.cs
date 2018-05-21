using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApplicationHostel.Models;
using AutoMapper;
using TestApplicationHostel.Dtos;

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
        public IEnumerable<GuestDto> GetGuests()
        {
            return _context.Guests.ToList().Select(Mapper.Map<Guest,GuestDto>);
        }

        public GuestDto GetGuestPiotr(string name, string city)
        {
            var guest = _context.Guests.SingleOrDefault(g => g.Name == "Piotr" & g.City == " Wrocław" );

            return Mapper.Map<Guest, GuestDto>(guest);
        }
        [HttpPut]
        public void UpdateGuest(int id, GuestDto guestDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var guestInDataBase = _context.Guests.SingleOrDefault(g => g.ID == id);

            if (guestInDataBase == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(guestDto, guestInDataBase);
                           
            _context.SaveChanges();

        }



    }
}
