using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava1
{
    class Heater
    {
        //properties
        public bool PowerSwitch { get; set; }
        public int Humidity { get; set; }
        public int Temperature { get; set; }
        //default constructor
        public Heater()
        {
        }
        public void WarmUp()
        {
            if (Temperature <= 200)
            {
                Temperature += 5;
            }
            else
            {
                Console.WriteLine("Heater at maximum temperature");
            }
        }
        public void CoolDown()
        {
            if (Temperature > 0)
            {
                Temperature -= 5;
            }
            else
            {
                Console.WriteLine("Heater at the coldest");
            }
        }
        // methods to control humidity
        public void HumidityUp()
        {
            if (Humidity <= 250)
            {
                Humidity += 5;
            }
            else
            {
                Console.WriteLine("Humidity at maximum");
            }
        }
        public void HumidityDown()
        {
            if (Humidity > 0)
            {
                Humidity -= 5;
            }
            else
            {
                Console.WriteLine("Humidity at minium");
            }
        }
        // method to print data
        public void PrintData()
        {
            Console.WriteLine("Heater data ");
            Console.WriteLine("- On/Off?: " + PowerSwitch);
            Console.WriteLine("- Temperature: " + Temperature);
            Console.WriteLine("- Humidity: " + Humidity);
        }
    }
}
