
using ModelLib.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib.Service
{
    public static class Storage
    {
        public static BimDb db = new BimDb();
        public static ObservableCollection<Marker> getAllMarkers()
        {
            db.Markers.Load();
            ObservableCollection<Marker> temp = db.Markers.Local;
            return temp;
        } 


    }
}
