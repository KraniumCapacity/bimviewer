using BimViewer.Database;
using BimViewer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BimViewer.Controllers
{
    public class ModelViewerThreeController : Controller
    {
        // GET: ModelViewerThree
        public ActionResult ModelViewerThree()
        {
            return View();
        }

        

        public void saveCoordinates(float x, float y, float z)
        {
            BimDb db = new BimDb();
            Marker mark = new Marker();
            mark.x = x;
            mark.y = y;
            mark.z = z;
            db.Markers.Add(mark);
            db.SaveChanges();
        }
    }
}