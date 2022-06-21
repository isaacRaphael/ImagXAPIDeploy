using ImagXAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImagXAPI.Contracts
{
    public interface IReplyRepository : IGenericRepository<Reply>
    {
        Task<ICollection<Reply>> GetCommentReplies(int commentId);
    }
    
}
