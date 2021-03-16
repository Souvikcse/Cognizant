using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public abstract class Factory
    {
        public abstract HeadLight makeHeadlight();
        public abstract Tire makeTire();
    }
}
