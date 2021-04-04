using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            BugattiVeyron bugatti = new BugattiVeyron();
            MovableAdapterImpl obj = new MovableAdapterImpl(bugatti);
            Console.WriteLine("Speed of Bugatti Veyron in kmph is :" + obj.getSpeed());
            Console.WriteLine("Price of Bugatti Veyron in Euros is :" + obj.getPrice());
            Console.ReadKey();
        }
    }
}
