

using ModelLib.Model;
using ModelLib.Service;
using System.Linq;
using System.Web.Mvc;

namespace BimViewer.Controllers
{
    public class ModelViewerThreeController : Controller
    {
        // GET: ModelViewerThree
        public ActionResult ModelViewerThree()
        {

            //var markers = Storage.db.Markers.Local.ToList();
            var markers = Storage.getAllMarkers();
            return View(markers);
        }

        

        public void saveCoordinates(float x, float y, float z, float normalX, float normalY, float normalZ)
        {
            BimDb db = new BimDb();
            Marker mark = new Marker();
            mark.x = x;
            mark.y = y;
            mark.z = z;
            mark.normalX = normalX;
            mark.normalY = normalY;
            mark.normalZ = normalZ;
            db.Markers.Add(mark);
            db.SaveChanges();
        }


     
    }
}