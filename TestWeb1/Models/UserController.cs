using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestWeb1.Models
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        public ActionResult Index()
        {
            return View();
        }
	}
    public class User
    {
        public string us
        {
            set;
            get;
        }
        public string mk
        {
            set;
            get;
        }



    }
   
    
}