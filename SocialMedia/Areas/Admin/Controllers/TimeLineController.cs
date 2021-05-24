using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SocialMedia.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize] //Sadece yetkili ler girer. Eğer yetkili değil ise Startupdaki ayara giderek admin/login uzantısına yönlendirir seni.

    public class TimeLineController : Controller
    {
        private readonly IRepository<Tweet> tweetService;

        public TimeLineController(IRepository<Tweet> tweetService)
        {
            this.tweetService = tweetService;
        }

        public IActionResult Index()
        {
            return View(tweetService.GetList());
        }

        public IActionResult InsertTweet()
        {
            return View();
        }



    }
}
