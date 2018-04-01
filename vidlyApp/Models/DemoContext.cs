using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace vidlyApp.Models
{
    public class DemoContext:DbContext
    {
        public DemoContext():base("vid")
        {
            this.Configuration.LazyLoadingEnabled = false;

        }
     
        public DbSet<Customer> cutomers { get; set; }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set;
        }
        public DbSet<MemberShiptype> MemberShipTypes { get; set; }
      
    }
}