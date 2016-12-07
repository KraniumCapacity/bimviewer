
using ModelLib.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ModelLib.Service
{
    public class BimDb : DbContext
    {
    
        public DbSet<BIM> Bims { get; set; }
        public DbSet<Marker> Markers { get; set; }
    }
}