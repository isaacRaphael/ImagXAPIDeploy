using ImagXAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImagXAPI.Contracts
{
    public interface ILikeRepository : IGenericRepository<Like>
    {
        Task<ICollection<Like>> GetLikesOfUser(string userId);
        Task<ICollection<Like>> LikesOfAPost(int postId);
        Task<bool> UserHasLiked(string userId, int postId);
    }
    
}
