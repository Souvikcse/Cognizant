using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Builder
{
    public class ChildPackage : IPackageBuilder
    {
        Package p = new Package();
        public void AddSavories()
        {
            p.Add("1 Savories");
        }

        public void AddSweets()
        {
            p.Add("2 Sweets");
        }

        public Package GetPackage()
        {
            return p;
        }
    }
}
