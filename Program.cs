using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi1 = new Taxi();
            Taxi taxi2 = new Taxi();
            Taxi taxi3 = new Taxi();
            Taxi taxi4 = new Taxi();

            taxi1.DriverName = " Dion ";
            taxi1.OnDuty = true;
            taxi1.NumPassenger = 13;

            taxi2.DriverName = " Andi ";
            taxi2.OnDuty = true;
            taxi2.NumPassenger = 15;

            taxi3.DriverName = " Tomo ";
            taxi3.OnDuty = false;
            taxi3.NumPassenger = 17;

            taxi4.DriverName = " Aldi ";
            taxi4.OnDuty = false;
            taxi4.NumPassenger = 11;

            taxi1.TaxiInfo();
            taxi1.PickUpPassenger();
            taxi1.DropOffPassanger();

            taxi2.TaxiInfo();
            taxi2.PickUpPassenger();
            taxi2.DropOffPassanger();

            taxi3.TaxiInfo();
            taxi3.PickUpPassenger();
            taxi3.DropOffPassanger();

            taxi4.TaxiInfo();
            taxi4.PickUpPassenger();
            taxi4.DropOffPassanger();

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
