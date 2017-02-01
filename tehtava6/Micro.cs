using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava6
{
    class Micro
    {
        //properties
        public bool PowerSwitch { get; set; }
        public int Watts { get; set; }
        public int Time { get; set; }
        //default constructor
        public Micro()
        {
        }
        public void WattsUp()
        {
            if (Watts <= 750)
            {
                Watts += 50;
            }
            else
            {
                Console.WriteLine("Watts maxed at 750");
            }
        }
        public void WattsDown()
        {
            if (Watts > 50)
            {
                Watts -= 50;
            }
            else
            {
                Console.WriteLine("Watts at the minimum");
            }
        }
        // methods to control humidity
        public void TimeUp()
        {
            if (Time <= 600)
            {
                Time += 30;
            }
            else
            {
                Console.WriteLine("Time at Max");
            }
        }
        public void TimeDown()
        {
            if (Time > 0)
            {
                Time -= 30;
            }
            else
            {
                Console.WriteLine("Time at Min");
            }
        }
        // method to print data
        public void PrintData()
        {
            Console.WriteLine("Microwave data ");
            Console.WriteLine("- On/Off?: " + PowerSwitch);
            Console.WriteLine("- Wattage: " + Watts);
            Console.WriteLine("- Time: " + Time);
        }
    }
}
