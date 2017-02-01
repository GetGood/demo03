using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava2
{
    class Washer
    {
        // properties
        public string Model { get; set; }
        public int Temperature { get; set; }
        public bool PowerSwitch { get; set; }
        public string Load { get; set; }

        // constructors
        public Washer()
        {

        }
     //   public Washer(string load)
       // {
        //    Load = load;
        //}
        public Washer(string model)
        {
            Model = model;

        }
        // methods

        public void TempUp()
        {
            if (Temperature < 70)
            {
                Temperature += 5;
            }
            else
            {
                Console.WriteLine("Temperature is at maximum");
            }
        }
        public void TempDown()
        {
            if (Temperature > 0)
            {
                Temperature -= 5;
            }
            else
            {
                Console.WriteLine("Temperature is at minimum");
            }
        }

        // methods to control load
        public void LoadUp()
        {
            if (Load == "empty")
            {
                Load = "half full";
            }
            else if (Load == "half full")
            {
                Load = "full";
            }
            else
            {
                Console.WriteLine("Machine is already full");
            }
        }
        public void LoadDown()
        {
            if (Load == "full")
            {
                Load = "half full";
            }
            else if (Load == "half full")
            {
                Load = "empty";
            }
            else
            {
                Console.WriteLine("Machine is already empty");
            }
        }

        // method to print out data

        public void PrintData()
        {
            Console.WriteLine("Washing machine data: ");
            Console.WriteLine("Washing machine model " + Model);
            Console.WriteLine("Temperature: " + Temperature);
            Console.WriteLine("Load: " + Load);
            Console.WriteLine("Power on/off " + PowerSwitch);
        }
    }
}