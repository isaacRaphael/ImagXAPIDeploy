using AutoMapper;
using ImagXAPI.DTOs.OutGoing;
using ImagXAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Helpers.MappingProfiles
{
    public class ReplyProfile : Profile
    {
        public ReplyProfile()
        {
            CreateMap<Reply, ReplyResponseDto>().ForMember(d => d.ReplierId, opt => opt.MapFrom(s => s.AppUserId));
        }
    }
}
