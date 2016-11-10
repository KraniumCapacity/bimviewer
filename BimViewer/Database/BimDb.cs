using BimViewer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BimViewer.Database
{
    public class BimDb : DbContext
    {
    
        public DbSet<BIM> Bims { get; set; }
    }
}