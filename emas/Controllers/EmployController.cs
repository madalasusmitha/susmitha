using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using emas.Models;

namespace emas.Controllers
{
    public class EmployController:Controller
    {
        // Interface empr = new Employr();
        private readonly Interface empr;
       public EmployController(Interface emr)
        {
            empr = emr;
        }
        //public string Search()
        //{
        //    Employ emp1 = empr.GetEmploy(1);
        //    return emp1.Id + "\n" + emp1.Name + "\n" + emp1.Email + "\n" + emp1.dept;
        //}
        //public string Index()
        //{
           
        //    return "hiiii";
        //}
        public IActionResult Search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);
            Employ emp1 = empr.GetEmploy(ID);
            //if (emp1 != null)
            //{
            //    return Content(emp1.Id + "\n" + emp1.Name + "\n" + emp1.Email + "\n" + emp1.dept);
            //}
            //else
            //    return Content("employ does not exist");
            //ViewData["id"] = emp1.Id;
            //ViewData["name"] = emp1.Name;
            //ViewData["email"] = emp1.Email;
            //ViewData["dept"] = emp1.dept;
            //ViewBag.id = emp1.Id;
            //ViewBag.name = emp1.Name;
            //ViewBag.email = emp1.Email;
            //ViewBag.dept = emp1.dept;
            //return View();
            ViewData["Employ"] = emp1;
            ViewBag.Employ = emp1;
            return View(emp1);


        }

        //public string ContactUs()
        //{
        //    return "hiiii";
        //}
        //public JsonResult AboutUs()
        //{
        //    return JsonResult("{(id:1;name:")
        //}
        public IActionResult Index()
        {
            List<Employ> elist = empr.displayDetails();
            return View(elist);
        }
        public ViewResult AboutCompany()
        {
            Employ emp = empr.GetEmploy(2);
            //ViewBag.projectName = "BookHive";
            EmployeeViewModel ep = new EmployeeViewModel();
            ep.employee = emp;
            ep.projectName = "BookHive";
                
            return View(ep);
                


        }
        public IActionResult GetAllEmployees()
        {
            List<Employ> elist = empr.displayDetails();
            return View("~/Views/Employ/Index.cshtml", elist);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employ emp)
        {
            if (ModelState.IsValid)
            {
                empr.AddEmploy(emp);
                return RedirectToAction("Index");
            }
            //else
            // return View("Fail");
            return View();
        }
        
        public IActionResult List()
        {
            List<Employ> elist = empr.displayDetails();
            return View(elist);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Employ employ)
        {
            bool res = empr.AddEmploy(employ);
            return RedirectToAction("Index"); 
        }
        public bool IsExist(string email)
        {
            var result = (empr.displayDetails()).Find(r => r.Email == email);
            if (result == null) return true;
            else
                return false;
        }
        [AcceptVerbs("Get","Post")]
        
        public JsonResult IsMailExists(string email)
        {
            return IsExist(email) ? Json(true) : Json("email exists");
        }
        public IActionResult mypartial()
        {
            return View();
        }

    }
}

