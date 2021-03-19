using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Case_Study___I.Factory
{
    public class Toys : Order
    {
        public Toys(string channel, string productType) : base(channel, productType)
        {
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine("Toys order accepted");
            Console.WriteLine(base.ToString());
        }
    }
}
