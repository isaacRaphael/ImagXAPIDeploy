using AutoMapper;
using ImagXAPI.DTOs.InComing;
using ImagXAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Helpers.MappingProfiles
{
    public class BuddyRequestProfile : Profile
    {
        public BuddyRequestProfile()
        {
            CreateMap<BuddyRequestDto, BuddyRequest>().ReverseMap();
        }
    }
}
