using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyBlog.DataAccess.Concrate;
using MyBlog.DataAccess.Repositories;
using MyBlog.Entities.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        ContactRepository _contactRepository = new ContactRepository(new Context());
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.ContactDate = DateTime.Now;
            contact.Status = true;
            
            _contactRepository.Insert(contact);

            return RedirectToAction("Index","Blog");
        }
    }
}