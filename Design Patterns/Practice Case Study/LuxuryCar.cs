using System;

namespace Practice_Case_Study
{
    public class LuxuryCar : Car

    {
        public LuxuryCar(CarType carType, Location location) : base(CarType.LUXURY, location)

        {

            Construct();

        }

        public override void Construct()

        {

            Console.WriteLine("Connecting to luxury car");

            Console.WriteLine(base.ToString());

        }

    }
}
