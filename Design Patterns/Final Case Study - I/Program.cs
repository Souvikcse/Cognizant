using Final_Case_Study___I.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Case_Study___I
{
    class Program
    {
        static void Main(string[] args)
        {
            string channel = "E-commerce";
            string productType = "Toys";

            FactoryGetter fg = new FactoryGetter();
            fg.PlaceOrder(channel, productType);

            Console.Read();
        }
    }
}
