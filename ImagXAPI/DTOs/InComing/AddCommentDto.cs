using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.DTOs.InComing
{
    public class AddCommentDto
    {
        public string PayLoad { get; set; }
        public int PostId { get; set; }
        public string CommenterID { get; set; }
    }
}
