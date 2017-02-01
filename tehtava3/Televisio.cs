using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava3
{
    class Televisio
    {
        // properties
        public string Model { get; set; }
        public int Volume { get; set; }
        public int Channel { get; set; }
        public bool PowerSwitch { get; set; }



        // constructors
        public Televisio()
        {

        }
        public Televisio(string model)
        {
            Model = model;
        }

        // methods

        // method to change volume

        public void VolumeDown()
        {
            if (Volume > 0)
            {
                Volume -= 1;
            }
            else
            {
                Console.WriteLine("Muted");
            }
        }
        public void VolumeUp()
        {
            if (Volume < 11)
            {
                Volume += 1;
            }
            else
            {
                Console.WriteLine("this went to eleven");
            }
        }

        // method to change channels

        public void ChannelUp()
        {
            if (Channel < 100)
            {
                Channel += 1;
            }
            else
            {
                Channel = 0;
            }
        }
        public void ChannelDown()
        {
            if (Channel > 0)
            {
                Channel -= 1;
            }
            else
            {
                Channel = 100;
            }
        }

        // method to print out data

        public void PrintData()
        {
            Console.WriteLine("Volume: " + Volume);
            Console.WriteLine("Channel: " + Channel);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("power on/off? : " + PowerSwitch);
        }
    }
}