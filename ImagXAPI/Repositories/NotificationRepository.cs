﻿using ImagXAPI.Contracts;
using ImagXAPI.Data;
using ImagXAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Repositories
{
    public class NotificationRepository : GenericRepository<Notification> , INotificationRepository
    {
        private readonly AppDbContext _context;

        public NotificationRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async  Task<ICollection<Notification>> GetUserNotifications(string id)
        {
            var notifications = await _context.Notifications.Where(n => n.RecipientID == id).ToListAsync();
            if (notifications is null)
                return null;

            return notifications;
        }
    }
}
