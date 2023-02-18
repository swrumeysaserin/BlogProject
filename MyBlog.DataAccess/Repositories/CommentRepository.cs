using MyBlog.DataAccess.Abstract;
using MyBlog.DataAccess.Concrate;
using MyBlog.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Repositories
{
    public class CommentRepository : GenericRepository<Comment>, ICommentRepository
    {
        public CommentRepository(Context database) : base(database)
        {
        }

        public List<Comment> GetAllList(int id)
        {
            return GetAllList(cmnt => cmnt.BlogId == id);
        }
    }
}
