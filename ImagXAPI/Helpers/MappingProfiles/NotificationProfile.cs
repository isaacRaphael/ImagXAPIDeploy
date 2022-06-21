using AutoMapper;
using ImagXAPI.DTOs.OutGoing;
using ImagXAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Helpers.MappingProfiles
{
    public class NotificationProfile : Profile
    {
        public NotificationProfile()
        {
            CreateMap<Notification, NotificationResponseDto>();
        }
    }
}
