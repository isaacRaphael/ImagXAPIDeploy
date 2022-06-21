using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.DTOs.InComing
{
    public class AddfilterDto
    {
        [Required]
        public IFormFile Media  { get; set; }
        [Required]
        public string Filter { get; set; }

    }

    public class CompressImageDto
    {
        [Required]
        public IFormFile Media { get; set; }
        [Required]
        public int CompressionIndex { get; set; }

    }

    public class ConvertImageDto
    {
        [Required]
        public IFormFile Media { get; set; }
        [Required]
        public string Format { get; set; }
    }
}
