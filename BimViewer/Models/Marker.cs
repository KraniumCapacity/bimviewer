using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BimViewer.Models
{
    public class Marker
    {
        public int id { get; set; }

        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }
    }
}