using ImagXAPI.Entities;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Hubs
{
    public class NotificationHub : Hub
    {
        public async Task NewNotificationReceived(Notification newNotification, string receiverConnectionId)
        {
            await Clients.Client(receiverConnectionId).SendAsync("NewNotificationReceived" , newNotification);
        }

        public string GetDonnectionId() => Context.ConnectionId;
    }
}
