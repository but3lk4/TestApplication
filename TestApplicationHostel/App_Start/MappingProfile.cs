using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using TestApplicationHostel.Models;
using TestApplicationHostel.Dtos;

namespace TestApplicationHostel.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Guest, GuestDto > ();
            Mapper.CreateMap<GuestDto, Guest>();
        }

    }
}