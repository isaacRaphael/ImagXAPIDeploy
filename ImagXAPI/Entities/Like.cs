﻿using ImagXAPI.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImagXAPI.Entities
{
    public class Like : BaseEntity
    {
        public Like()
        {
            Created = DateTime.UtcNow;

        }

        public Post Post { get; set; }
        public int PostId  { get; set; }
        public AppUser AppUser { get; set; }
        [ForeignKey(nameof(AppUserId))]
        public  string AppUserId { get; set; }
    }
}
