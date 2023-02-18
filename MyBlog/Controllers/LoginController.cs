using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlog.DataAccess.Concrate;
using MyBlog.DataAccess.Repositories;
using MyBlog.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MyBlog.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        WriterRepository _writerRepository = new WriterRepository(new Context());

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(Writer writer)
        {
            var checkedUser = _writerRepository.LoginCheck(writer);

            if (checkedUser != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,writer.Email)
                };

                var userIdentity = new ClaimsIdentity(claims, "a");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                
                return RedirectToAction("Index", "Writer");
            }
            return View();
        }
    }
}