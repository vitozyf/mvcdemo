using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HelloController : Controller
    {
        //GET: Hello
        public ActionResult Index(string name, int age = 0)
        {
            ViewBag.name = name;
            ViewBag.age = age;
            return View();
        }
        //public string Index(string name, int age = 0, int ID = 1)
        //{
        //    //return "hello word" + name + "age = " + age.ToString();
        //    return HttpUtility.HtmlEncode("hello word" + name + "age = " + age.ToString() + "ID="+ID.ToString());
        //}
    }
}