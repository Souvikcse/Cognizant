using BuilderDemo.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            IPackageBuilder b1 = new AdultPackage();
            IPackageBuilder b2 = new ChildPackage();

            director.Construct(b1);
            Package p1 = b1.GetPackage();
            p1.Show();

            director.Construct(b2);
            Package p2 = b2.GetPackage();
            p2.Show();

            Console.Read();
        }
    }
}
