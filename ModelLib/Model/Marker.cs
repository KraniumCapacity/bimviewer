using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Numerics;

namespace ModelLib.Model
{
    public class Marker
    {
        public int id { get; set; }

        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public float normalX { get; set; }
        public float normalY { get; set; }
        public float normalZ { get; set; }
    }
}