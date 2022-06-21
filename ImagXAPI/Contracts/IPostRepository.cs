using ImagXAPI.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ImagXAPI.Contracts
{
    public interface IPostRepository : IGenericRepository<Post>
    {
        Task<ICollection<Post>> GetPostByUser(string id);
        Task<ICollection<Post>> GetPostsOfBuddies(string id);
        Task<bool> UpdateImages(Post post);
    }
    
}
