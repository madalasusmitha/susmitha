 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using employee.Models;

namespace employee.Controllers
{
    public class EmployController:Controller
    {
        Interface empr = new Employr();
        public string Search()
        {
            Employ emp1 = empr.GetEmploy(1);
            return emp1.Id + "\n" + emp1.Name + "\n" + emp1.Email + "\n" + emp1.dept;
        }
        public string Index()
        {
            return "hiiii";
        }
        //public string ContactUs()
        //{
        //    return "hiiii";
        //}
        //public JsonResult AboutUs()
        //{
        //    return JsonResult("{(id:1;name:")
        //}
        //public ViewResult AboutUs()
        //{
        //    return View();
        //}
    }
}

