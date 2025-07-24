using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Extensions;
using api.Models;

namespace api.Interfaces
{
    public interface ICommentRepository
    {
        Task<List<Comment>> GetAllAsync(CommentQueryObject queryObject);
        Task<Comment?> GetByIdAsync(int id);
        Task<Comment> CreateAsync(Comment commenModel);
        Task<Comment?> UpdateAsync(int id, Comment commenModel);
        Task<Comment?> DeleteAsync(int id);
    }
}