using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava2
{

    class Program
    {
        static void Main(string[] args)
        {
            Washer washer = new Washer();
            washer.Model = "Whirlpool 100";
            washer.Load = "empty";
            washer.PrintData();
            washer.PowerSwitch = true;
            washer.LoadUp();
            washer.PrintData();
            washer.LoadUp();
            washer.PrintData();
            washer.LoadUp();
            washer.PrintData();
            washer.LoadDown();
            washer.PrintData();
            washer.TempUp();
            washer.PrintData();
            washer.LoadDown();
            washer.PrintData();

            Console.ReadLine();
        }
    }
}