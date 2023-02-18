using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyBlog.DataAccess.Concrate;
using MyBlog.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogRepository _blogRepository = new BlogRepository(new Context());
        public IActionResult Index()
        {
            var blogList = _blogRepository.GetBlogListWithCategory();
            return View(blogList);
        }
        public IActionResult BlogDetail(int id)
        {
            ViewBag.blogId = id;
            var blog = _blogRepository.GetBlogById(id);
            return View(blog);
        }

        public IActionResult BlogListByWriterId()
        {
            var blogs = _blogRepository.GetBlogListByWriter(1);

            return View(blogs);
        }
    }
}
