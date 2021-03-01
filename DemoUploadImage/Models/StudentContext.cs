using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DemoUploadImage.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("myConn")
        {
            Database.SetInitializer<StudentContext>(new CreateDatabaseIfNotExists<StudentContext>());
        }
        public DbSet<Student> Students { get; set; }
    }
}