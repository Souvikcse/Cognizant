using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class MercedesHeadlight : HeadLight
    {
        public override string GetHeadlight()
        {
            return "HeadLight for Mercedes";
        }
    }
}
