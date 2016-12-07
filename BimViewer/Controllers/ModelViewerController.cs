
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BimViewer.Controllers
{
    public class ModelViewerController : Controller
    {
        // GET: ModelViewer
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult ModelViewer()
        //{
        //    ViewBag.Message = "This is the model viewer";

        //    return View();
        //}



        [HttpPost]
        public ActionResult Upload()
        {
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];

                if (file != null && file.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Resources/Data/"), fileName);
                    file.SaveAs(path);
                }
            }

            return RedirectToAction("ModelViewer");
        }

        public ActionResult ModelViewer()
        {
            DirectoryInfo directory = new DirectoryInfo(Server.MapPath(@"~/Resources/Data/"));
            List<FileInfo> files = directory.GetFiles().ToList();
            List<string> filePaths = files.Where(x => x.Extension == ".wexbim").OrderBy(x => x.Name).Select(x => x.Name).ToList();
            
            return View(filePaths);
        }

   
        
    }

}