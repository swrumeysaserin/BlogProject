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
    public class AboutController : Controller
    {
        AboutRepository _aboutRepository = new AboutRepository(new Context());
        public IActionResult Index()
        {
            var aboutList = _aboutRepository.GetAllList();
            return View(aboutList);
        }

        public PartialViewResult AboutSocialMedia()
        {
            return PartialView();
        }
    }
}