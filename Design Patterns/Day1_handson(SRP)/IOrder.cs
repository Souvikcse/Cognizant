using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_handson_SRP_
{
    public interface IOrder
    {
        void ProcessOrder(string modelName);
    }
}
