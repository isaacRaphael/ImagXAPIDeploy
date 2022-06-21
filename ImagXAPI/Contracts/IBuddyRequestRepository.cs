using ImagXAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImagXAPI.Contracts
{
    public interface IBuddyRequestRepository : IGenericRepository<BuddyRequest>
    {
        Task<bool> ConfirmBuddyRequest(int id);
    }
    
}
