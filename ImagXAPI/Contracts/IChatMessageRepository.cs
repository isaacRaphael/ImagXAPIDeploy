using ImagXAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Contracts
{
    public interface IChatMessageRepository : IGenericRepository<ChatMessage>
    {
    }
}
