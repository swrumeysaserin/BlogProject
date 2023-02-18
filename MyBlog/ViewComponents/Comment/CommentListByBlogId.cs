using Microsoft.AspNetCore.Mvc;
using MyBlog.DataAccess.Concrate;
using MyBlog.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.ViewComponents.Comment
{
    public class CommentListByBlogId:ViewComponent
    {
        CommentRepository _commentRepository = new CommentRepository(new Context());
        public IViewComponentResult Invoke(int id)
        {
            var comments = _commentRepository.GetAllList(id);
            return View(comments);
        }
    }
}