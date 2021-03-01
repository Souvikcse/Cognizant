using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityIntro
{
    class DemoContext : DbContext
    {
        public DemoContext(): 
            base("Test")
        {

        }

        public virtual DbSet<Employee> Employees { get; set; }
    }
}
