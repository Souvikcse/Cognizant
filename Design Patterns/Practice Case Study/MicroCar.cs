using System;

namespace Practice_Case_Study
{
    public class MicroCar : Car
    {
        public MicroCar(CarType carType, Location location) : base(CarType.MICRO, location)
        {
            Construct();
        }

        public override void Construct()
        {
            Console.WriteLine("Connecting to Micro car");
            Console.WriteLine(base.ToString());
        }

    }
}
