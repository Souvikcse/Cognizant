using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class Package
    {
        private string details = "";
        public void Add(string parts)
        {
            details += parts + " ";
        }

        public void Show()
        {
            Console.WriteLine(details);
        }
    }
}
