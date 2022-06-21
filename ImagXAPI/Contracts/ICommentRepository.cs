using ImagXAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImagXAPI.Contracts
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        Task<ICollection<Comment>> GetCommentsOfPost(int postId);
    }
    
}
