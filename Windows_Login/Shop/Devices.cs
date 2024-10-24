using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
    public abstract class Devices : IGSM
    {
        public string DeviceName { get; set; }
        public int YearOfProduction { get; set; }
        public string Color { get; set; }
        public string SerialNumber { get; set; }

        // Abstract method for operation
        public abstract void Hoatdong();  // Functionality of device using 4G, WiFi, GPRS, or GSM.

        // Virtual method for UsingGSM, can be overridden
        public virtual void UsingGSM()
        {
            Console.WriteLine($"{DeviceName} is using GSM.");
        }
    }
}