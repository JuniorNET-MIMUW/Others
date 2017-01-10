using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TodoAppWithBackand.Models;

namespace TodoAppWithBackand.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<TodoViewModel> list;

        static HomeController()
        {
            list = new List<TodoViewModel>()
            {
                new TodoViewModel() {Name = "Completed", IsCompleted = true},
                new TodoViewModel() {Name = "Incomplete", IsCompleted = false}
            };
            
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetList() => Json(list);
    }
}