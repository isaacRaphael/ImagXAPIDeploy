using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.DTOs.InComing
{
    public class AddLikeDto
    {
        public int PostId { get; set; }
        public string UserId { get; set; }
    }
}
