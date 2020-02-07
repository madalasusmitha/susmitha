using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Seller.Model;

namespace Seller.controllers
{
    public class sellercontroller:Controller
    {
        Interface ser = new sellerbo();
       
        public string Search()
        {
            seller sel = ser.Getseller(234);
            return sel.Id + "\n" + sel.Name + "\n" + sel.password + "\n" + sel.Companyname + "\n" + sel.GSTIN+"\n"+sel.briefdetails+"\n"+sel.postal_address+"\n"+sel.website+"\n"+sel.emailid+"\n"+sel.contactnumber ;

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
