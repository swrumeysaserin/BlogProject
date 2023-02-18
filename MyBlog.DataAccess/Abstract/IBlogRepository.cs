using MyBlog.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.DataAccess.Abstract
{
    public interface IBlogRepository : IGenericRepository<Blog>
    {
        List<Blog> GetListWithCategory();

        List<Blog> GetLast3Blogs();

        List<Blog> GetBlogListWithCategory();
        
        List<Blog> GetBlogById(int id);

        List<Blog> GetBlogListByWriter(int id);

    }
}
