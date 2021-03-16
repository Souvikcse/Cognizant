using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main()
        {
            DBConn obj1 = DBConn.getInstance();
            DBConn obj2 = DBConn.getInstance();
            Console.Read();
        }
    }
}
