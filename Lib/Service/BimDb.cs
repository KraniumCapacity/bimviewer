
using Lib.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Lib.Database
{
    public class BimDb : DbContext
    {
    
        public DbSet<BIM> Bims { get; set; }
        public DbSet<Marker> Markers { get; set; }
    }
}