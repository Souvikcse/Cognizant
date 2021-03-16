using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class AudiTire : Tire
    {
        public override string GetTire()
        {
            return "Tire for Audi";
        }
    }
}
