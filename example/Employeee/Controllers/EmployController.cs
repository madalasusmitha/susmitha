using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Employeee.Models;
using Employeee.repository;

namespace Employeee.Controllers
{
    public class EmployController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {


            return View();
        }
        public IActionResult Create(Emoloye item)
        {
            emprepository rep = new emprepository();
            rep.Add(item);
            return RedirectToAction("Login");
        }
        public IActionResult Login(string eid, string password)
        {
            emprepository rep = new emprepository();
            Emoloye em = rep.validate(eid, password);
            if (em != null)
            {
                return RedirectToAction("Details");
            }
            else
            {
                ViewData["err"] = "Invalid Credential";
                return View();
            }

        }
        public IActionResult Details(Emoloye item)
        {
            return View(item);
        }
    }
}