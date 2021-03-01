using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoContext db = new DemoContext();
            //Employee emp = new Employee()
            //{
            //    Id = 1,
            //    Name = "Souvik"
            //};
            //db.Employees.Add(emp);
            //db.SaveChanges();

            string date = "22-12-2016";
            Console.WriteLine(DateTime.ParseExact(date, "d-M-yyyy", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
