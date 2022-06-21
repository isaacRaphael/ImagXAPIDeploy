using AutoMapper;
using ImagXAPI.DTOs.OutGoing;
using ImagXAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Helpers.MappingProfiles
{
    public class PostProfile : Profile
    {
        public PostProfile()
        {
            CreateMap<Post, PostResponseDto>().ForMember(d => d.CreatedOn, opt => opt.MapFrom(s => s.Created));
        }
    }
}
