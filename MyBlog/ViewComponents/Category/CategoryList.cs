using Microsoft.AspNetCore.Mvc;
using MyBlog.DataAccess.Concrate;
using MyBlog.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.ViewComponents.Category
{
    public class CategoryList:ViewComponent
    {
        CategoryRepository _categoryRepository = new CategoryRepository(new Context());
        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetAllList();
            return View(categories);
        }
    }
}