using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo.Builder
{
    public class AdultPackage : IPackageBuilder
    {
        Package p = new Package();
        public void AddSavories()
        {
            p.Add("2 savories");
        }

        public void AddSweets()
        {
            p.Add("2 sweets");
        }

        public Package GetPackage()
        {
            return p;
        }
    }
}
