using AutoMapper;
using ImagXAPI.DTOs.OutGoing;
using ImagXAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Helpers.MappingProfiles
{
    public class CommentProfile : Profile
    {
        public CommentProfile()
        {
            CreateMap<Comment, CommentResponseDto>().ForMember(d => d.CommenterID, opt => opt.MapFrom(s => s.AppUserId));
        }
    }
}
