using AutoMapper;
using ImagXAPI.DTOs.InComing;
using ImagXAPI.DTOs.OutGoing;
using ImagXAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Helpers.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<AppUser, UserResponseDto>();
            CreateMap<UserRegistrationDto, AppUser>();
        }
    }
}
