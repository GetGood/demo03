using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carluokka
{
    class Program
    {
        static void Main(string[] args)
        {
            // create one instance of car class
            Car car = new Car();
            car.PrintData();
            car.Model = "Datsun 100A";
            car.Color = "Yellow";
            car.Engine = 1.0;
            car.Speed = 10;
            car.FuzzyDices = true;
            car.DoorCount = 2;
            Car.SomeProperty = 100;
            car.PrintData();
            car.Accelerate();
            Console.WriteLine("Speed = " + car.Speed);
            car.Brake(2);
            Console.WriteLine("Speed = " + car.Speed);

            // create a new instance from Car class
            Car nascar = new Car("Speedstrep");
            nascar.PrintData();
            nascar.Color = "Black";
            nascar.Engine = 5.0;
            nascar.FuzzyDices = true;
            nascar.PrintData();
        }
    }
}
