using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoCokkie.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoCokkie.Controllers
{
    public class CookiesessionController : Controller
    {
        public readonly UserAccountContext _context;
        public CookiesessionController(UserAccountContext context)
        {
            this._context = context;
        }
        
                // GET: Cookiesession
        [HttpGet]
        public ActionResult RegisterUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(UserAccount uc)
        {
            try
            {
                _context.Add(uc);
                _context.SaveChanges();
                ViewBag.message = uc.UserName + "has got succesfully registered";

            }catch(Exception e)
            {
                ViewBag.message = uc.UserName + "Registration Failed";
            }
            return View();
        }
[HttpGet]
public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserAccount user)
        {
            var loguser = _context.UserAccounts.Where(e => e.UserName == user.UserName && e.Password == user.Password).ToList();
            if (loguser.Count == 0)
            {
                ViewBag.message = "Not valid user";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("UserName",user.UserName);


                return RedirectToAction("CreateDashBoard");
            }

        }
        public ActionResult CreateDashboard()

        {

        
            ViewBag.UserName = HttpContext.Session.GetString("UserName").ToString();
            return View();        }

        // GET: Cookiesession/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Cookiesession/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cookiesession/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cookiesession/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Cookiesession/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Cookiesession/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Cookiesession/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}