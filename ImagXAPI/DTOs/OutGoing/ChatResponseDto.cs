﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.DTOs.OutGoing
{
    public class ChatResponseDto
    {
        public int Id { get; set; }
        public string PartyAId { get; set; }
        public string PartyBId { get; set; }
    }
}
