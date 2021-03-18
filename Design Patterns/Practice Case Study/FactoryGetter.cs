using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Case_Study
{
    public class FactoryGetter
    {
        public void GetCar(CarType carType, Location location)
        {
            if (carType == CarType.LUXURY)
            {
                Car car = new LuxuryCar(carType, location);
                //car.Construct();
            }
            else if (carType == CarType.MICRO)
            {
                Car car = new MicroCar(carType, location);
                //car.Construct();
            }
            else if (carType == CarType.MINI)
            {
                Car car = new MicroCar(carType, location);
                //car.Construct();
            }
        }
    }
}
