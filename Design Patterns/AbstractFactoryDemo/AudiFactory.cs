using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class AudiFactory : Factory
    {
        public override HeadLight makeHeadlight()
        {
            return new AudiHeadlight();
        }

        public override Tire makeTire()
        {
            return new AudiTire();
        }
    }
}
