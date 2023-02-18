using Microsoft.EntityFrameworkCore;
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
    public class BlogRepository : GenericRepository<Blog>, IBlogRepository
    {
        Context _database;
        public BlogRepository(Context database) : base(database)
        {
            _database = database;
        }

        public List<Blog> GetBlogById(int id)
        {
            return GetAllList(blg => blg.Id == id);
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return GetAllList(blg => blg.WriterId == id);
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return GetListWithCategory();
        }

        public List<Blog> GetLast3Blogs()
        {
            return GetAllList().Take(3).ToList();
        }

        public List<Blog> GetListWithCategory()
        {
            return _database.Blogs.Include(blg => blg.Category).ToList();
        }
    }
}
