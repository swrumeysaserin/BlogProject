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
    public class SubscriberController : Controller
    {
        SubscriberRepository _subscriberRepository = new SubscriberRepository(new Context());

        [HttpGet]
        public PartialViewResult AddSubscribe()
        {
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult AddSubscribe(Subscriber subscriber)
        {
            subscriber.Status = true;
            _subscriberRepository.Insert(subscriber);
            return PartialView();
        }
    }
}