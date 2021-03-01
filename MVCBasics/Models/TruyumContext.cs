using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCBasics.Models
{
    public class TruyumContext : DbContext
    {
        public TruyumContext() : base("myconn")
        {}

        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Cart> Cart { get; set; }

    }
}