using ImagXAPI.Contracts;
using ImagXAPI.Data;
using ImagXAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Repositories
{
    public class ChatMessageRepository : GenericRepository<ChatMessage>, IChatMessageRepository
    {
        public ChatMessageRepository(AppDbContext context) : base(context)
        {

        }
    }
}
