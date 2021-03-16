using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class Mercedesfactory : Factory
    {
        public override HeadLight makeHeadlight()
        {
            return new MercedesHeadlight();
        }

        public override Tire makeTire()
        {
            return new MercedesTire();
        }
    }
}
