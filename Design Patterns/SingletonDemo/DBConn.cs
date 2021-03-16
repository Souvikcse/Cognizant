using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    public sealed class DBConn
    {
        private static DBConn instance = null;
        private static int c = 0; 

        private DBConn()
        {
            c++;
            Console.WriteLine("Counter Value: " + c);
        }

        public static DBConn getInstance()
        {
            if (instance == null)
            {
                instance = new DBConn();
            }
            return instance;
        }
    }
}
