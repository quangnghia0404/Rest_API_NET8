using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Helpers;
using api.Models;

namespace api.Interfaces
{
    public interface IcommentRepository
    {
        Task<List<Comment>> GetAllAsync(CommentQueryObject queryObject);
        Task<Comment> GetByIdAsync(int id);

        Task<Comment> CreateAsync(Comment commentModel);
        Task<Comment?> Updateasync(int id, Comment commentModel);
        Task<Comment> DeleteAsync(int id);
    }
}