using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = "Mercedes";

            var factory = FactoryGetter(type);

            var headlight = factory.makeHeadlight();
            Console.WriteLine(headlight.GetHeadlight());

            var tire = factory.makeTire();
            Console.WriteLine(tire.GetTire());
        }

        static Factory FactoryGetter(string type)
        {
            if (type == "Mercedes")
            {
                return new Mercedesfactory();
            }
            else if (type == "Audi")
            {
                return new AudiFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
