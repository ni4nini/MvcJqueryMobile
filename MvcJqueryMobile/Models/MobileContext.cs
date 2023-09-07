using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcJqueryMobile.Models
{
    public class MobileContext : DbContext
    {
        public MobileContext() : base("MobileConnection") { }
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Car> Cars {get; set; }
        public DbSet<Chair> Chairs { get; set; }
    }
}