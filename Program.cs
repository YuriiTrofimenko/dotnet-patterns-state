using System;

namespace StateSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();
            // car.FillTank();
            car.TurnKey();
            car.TurnKey();
            car.TurnKey();
            car.Drive();
            car.Stop();
            
            Console.ReadLine();
        }
    }
}
