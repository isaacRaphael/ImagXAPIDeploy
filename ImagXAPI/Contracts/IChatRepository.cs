using ImagXAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Contracts
{
    public interface IChatRepository : IGenericRepository<Chat>
    {
        Task<ICollection<Chat>> GetUserChats(string id);

        Task<Chat> GetTwoPartChat(string partyAId, string partyBId);
        Task<bool> GetTwoPartChatExists(string partyAId, string partyBId);
    }
}
