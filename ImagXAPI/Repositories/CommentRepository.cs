using ImagXAPI.Contracts;
using ImagXAPI.Data;
using ImagXAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Repositories
{
    public class CommentRepository : GenericRepository<Comment> , ICommentRepository
    {
        private readonly AppDbContext _context;

        public CommentRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<ICollection<Comment>> GetCommentsOfPost(int postId)
        {
            var comments = await _context.Comments.Where(x => x.PostId == postId).ToListAsync();
            if (comments is null)
                return null;

            return comments;
        }
    }
}
