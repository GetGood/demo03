using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava6
{
    class Program
    {
        static void Main(string[] args)
        {



            //create one instance of heater class
            Micro heater = new Micro();
            heater.PrintData();
            //testing...
            heater.PowerSwitch = true;
            heater.WattsUp();
            heater.PrintData();
            heater.WattsDown();
            heater.PrintData();
            heater.TimeUp();
            heater.PrintData();
            heater.TimeDown();
            heater.PrintData();
            heater.TimeDown();
            Console.ReadLine();
        }

    }
}
