using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava1
{
    class Program
    {
        static void Main(string[] args)
        {


             
            //create one instance of heater class
            Heater heater = new Heater();
            heater.PrintData();
            //testing...
            heater.PowerSwitch = true;
            heater.HumidityUp();
            heater.PrintData();
            heater.HumidityDown();
            heater.PrintData();
            heater.WarmUp();
            heater.PrintData();
            heater.CoolDown();
            heater.PrintData();
            heater.CoolDown();
            Console.ReadLine();
        }

    }
}
