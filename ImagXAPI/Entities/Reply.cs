﻿using ImagXAPI.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Entities
{
    public class Reply : BaseEntity
    {
        public Reply()
        {
            Created = DateTime.UtcNow;
        }
        public string PayLoad { get; set; }
        public DateTime Posted { get; set; }
        public Comment Comment { get; set; }
        public int CommentId { get; set; }
        public AppUser AppUser { get; set; }
        [ForeignKey(nameof(AppUserId))]
        public string AppUserId { get; set; }
    }
}
