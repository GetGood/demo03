using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tehtava3
{
    class Program
    {
        static void Main(string[] args)
        {
            Televisio televisio = new Televisio("Finnlux 1");
            televisio.PrintData();
            televisio.PowerSwitch = true;
            televisio.ChannelUp();
            televisio.PrintData();
            televisio.ChannelDown();
            televisio.PrintData();
            televisio.ChannelDown();
            televisio.PrintData();
        }
    }
}