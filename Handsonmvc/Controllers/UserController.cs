using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Handsonmvc.Controllers;
using Handsonmvc.Models;
using Handsonmvc.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Handsonmvc.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Country = new SelectList(new string[] {"", "india", "china", "us", "uk" });
        
            return View();
        }
        [HttpPost]
        public IActionResult Create(User item)
        {
            //ViewBag.Country =  newnew string[] { "india", "china", "us", "uk" };

            userrepository rep = new userrepository();
            rep.Add(item);
            return RedirectToAction("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string uname,string pwd)
        {
            userrepository rep = new userrepository();
            User user = rep.validate(uname, pwd);
            if(user!=null)
            {
                return RedirectToAction("Details");
            }
            else
            {
                ViewData["err"] = "Invalid Credential";
                return View();
            }
        }
        public IActionResult Details([Bind(include:"Name")]User item)
        {
            return View(item);
        }
        
    }
}