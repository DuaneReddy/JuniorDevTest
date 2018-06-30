using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVPTest.Models
{
    public class MvpContext : DbContext
    {
        public DbSet<Info> Inputs { get; set; }
        public DbSet<Extra> Extra{ get; set; }
    }
}