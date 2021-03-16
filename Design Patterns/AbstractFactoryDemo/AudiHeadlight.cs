using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class AudiHeadlight : HeadLight
    {
        public override string GetHeadlight()
        {
            return "Headlight for Audi";
        }
    }
}
