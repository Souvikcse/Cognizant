using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Case_Study___I.Factory
{
    public abstract class Order
    {
        public string Channel { get; set; }
        public string ProductType { get; set; }

        public Order(string channel, string productType)
        {
            this.Channel = channel;
            this.ProductType = productType;
        }

        public abstract void processOrder();
        public override string ToString()
        {
            return $"{ProductType} order accepted through {Channel} channel!";
        }
    }
}
