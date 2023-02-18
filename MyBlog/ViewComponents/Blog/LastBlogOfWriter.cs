using Microsoft.AspNetCore.Mvc;
using MyBlog.DataAccess.Concrate;
using MyBlog.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.ViewComponents.Blog
{
    public class LastBlogOfWriter:ViewComponent
    {
        BlogRepository _blogRepository = new BlogRepository(new Context());
        public IViewComponentResult Invoke()
        {
            var blogs = _blogRepository.GetBlogListByWriter(1);
            return View(blogs);
        }
    }
}