using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taxi
{
    public class Taxi
    {
        // properties
        public string DriverName { get; set; }
        public bool OnDuty { get; set; }
        public float NumPassenger { get; set; }
        public string Status { get; set; }

        //method
        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name: {0}", DriverName);

            if (OnDuty == true)
            {
                Status = "Yes";
            }
            else
            {
                Status = "No";
            }
            Console.WriteLine("On Duty : {0}", Status);
            Console.WriteLine("Num Passenger : {0}", NumPassenger);
        }
        public void PickUpPassenger()
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("{0} sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassanger()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", DriverName);
            Console.WriteLine("**************************************\n\n");
        }
    }
}
