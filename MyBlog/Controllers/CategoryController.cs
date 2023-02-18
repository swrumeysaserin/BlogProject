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
    public class CategoryController : Controller
    {
        CategoryRepository _categoryRepository = new CategoryRepository(new Context());

        public IActionResult Index()
        {
            var categoryList = _categoryRepository.GetAllList();
            return View(categoryList);
        }
    }
}