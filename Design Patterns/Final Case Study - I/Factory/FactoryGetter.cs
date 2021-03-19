using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Case_Study___I.Factory
{
    public class FactoryGetter
    {
        public void PlaceOrder(string channel, string productType)
        {
            if (productType == "Toys")
            {
                Order order = new Toys(channel, productType);
            }
            else if(productType == "Furniture")
            {
                Order order = new Furniture(channel, productType);
            }
            else if(productType == "Electronic Product")
            {
                Order order = new ElectronicProduct(channel, productType);
            }
        }
    }
}
