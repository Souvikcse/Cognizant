using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Case_Study___I.Factory
{
    public class ElectronicProduct : Order
    {
        public ElectronicProduct(string channel, string productType) : base(channel, productType)
        {
            processOrder();
        }
        public override void processOrder()
        {
            Console.WriteLine("Electronic product order accepted");
            Console.WriteLine(base.ToString());
        }
    }
}
