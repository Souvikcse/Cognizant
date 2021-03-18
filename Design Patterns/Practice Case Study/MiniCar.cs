using System;

namespace Practice_Case_Study
{
    public class MiniCar : Car

    {

        public MiniCar(CarType carType, Location location) : base(CarType.MINI, location)

        {

            Construct();

        }

        public override void Construct()

        {

            Console.WriteLine("Connecting to Mini car");

            Console.WriteLine(base.ToString());

        }

    }
}
