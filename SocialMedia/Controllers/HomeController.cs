using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;

using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SocialMedia.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SocialMedia.Controllers
{
    public class HomeController : Controller
    {
        //TweetManager tm = new TweetManager();
        
        private readonly IRepository<User> userService;
        private readonly IWebHostEnvironment env;

        public HomeController(IRepository<User> userService, IWebHostEnvironment env)
        {
            this.userService = userService;
            this.env = env;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //Kullanıcı Giriş İşlemleri
        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            if (userService.Any(x => x.Mail == user.Mail && x.Password == user.Password && x.Status == true))
            {

                User loggedUser = userService.Get(x => x.Mail == user.Mail && x.Password == user.Password);

                var claims = new List<Claim>() //Cookie'de tutuyoruz böyle, Claim nesnesiyle.
                {
                    new Claim("ID",loggedUser.UserId.ToString()),
                    new Claim(ClaimTypes.Name, loggedUser.FirstName),
                    new Claim(ClaimTypes.Surname, loggedUser.Surname),
                    new Claim(ClaimTypes.Email, loggedUser.Mail),
                };

                //Giriş işlemleri ve ardından yönetici sayfasına yönlendirme
                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index", "TimeLine", new { area = "Admin" });
            }
            else if (userService.Any(x => x.Mail == user.Mail && x.Password == user.Password && x.Status != true))
            {
                TempData["Message"] = "Kullanıcı aktif değil!";
                return View();
            }
            TempData["Message"] = "Kullanıcı bulunamadı!";
            return View();
        }

        //Kullanıcı çkış işlemleri
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();   //Çıkış işlemini gerçekeştirir.
            return RedirectToAction("Index", "Home");   //Area lazım değil
        }

    }
}
