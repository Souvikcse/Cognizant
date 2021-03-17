using BuilderDemo.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDemo
{
    public class Director
    {
        public void Construct(IPackageBuilder builder)
        {
            builder.AddSavories();
            builder.AddSweets();
        }
    }
}
