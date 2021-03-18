using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Case_Study
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarFactory carFactory = new ConcreteCarFactory();

            //CarClient carClient = new CarClient(carFactory);

            //carClient.BuildMicroCar(Location.USA);

            //carClient.BuildMiniCar(Location.INDIA);

            //carClient.BuildLuxuryCar(Location.DEFAULT);

            CarType ctype = CarType.MICRO;
            Location loc = Location.INDIA;

            FactoryGetter fg = new FactoryGetter();
            fg.GetCar(ctype, loc);

            Console.ReadKey();
        }
    }
}
