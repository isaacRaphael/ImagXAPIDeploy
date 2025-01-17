﻿using ImagXAPI.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options)
        {

        }

        public DbSet<BuddyRequest> BuddyRequests { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reply> Replies { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Friendship> Friendships { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }
        public DbSet<SharingKey> Keys { get; set; }
        public DbSet<ResetToken> ResetTokens { get; set; }
        public DbSet<Package> Packages { get; set; }



    }
}
