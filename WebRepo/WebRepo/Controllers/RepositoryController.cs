using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebRepo.Controllers
{
    public class RepositoryController : Controller
    {
        // GET: Repository
        public ActionResult Index()
        {
            string[] files = Directory.GetFiles(Server.MapPath("~/App_Data/Repo"));
            var fileNames = files.Select(Path.GetFileName);
            return View(fileNames);
        }

        // GET: Repository/Add
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                var fileName = Path.GetFileName(file.FileName);

                var path = Path.Combine(Server.MapPath("~/App_Data/Repo"), fileName);
                file.SaveAs(path);
            }
            return RedirectToAction("Index");
        }

        public ActionResult ViewFile(string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                path = Path.Combine(Server.MapPath("~/App_Data/Repo"), path);
                try
                {
                    var file = System.IO.File.ReadAllText(path);
                    if (Path.GetExtension(path) == ".txt")
                    {
                        ViewBag.Text = file;
                    }
                    else
                        ViewBag.Text = "Given file extention is not supported";
                }
                catch
                {
                    ViewBag.Text = "File not found";
                }
                
            }
            else
            {
                ViewBag.Text = "Input is empty";
            }
            return View();
        }
    }
}