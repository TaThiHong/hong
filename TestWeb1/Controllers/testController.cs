using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWeb1.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /test/
        public ActionResult Index()
        {
            return View();
        }

       public ActionResult About()
        {
            return View();
        }
        public ActionResult Logout()
       {
           Session["username"] = null;
           return RedirectToAction("Index");
       }
         [HttpPost]
        public ActionResult Test()
        {
            string us = Request.Form["us"];
            string mk = Request.Form["mk"];
             if("admin".Equals(us) && "123".Equals(mk))
             {
                 Session["username"] = us;
                 ViewBag.msg = "thanh cong";
             }
             else
                 ViewBag.msg = "that bai";
            ViewBag.us = us;
            return View();
        }
   }
}