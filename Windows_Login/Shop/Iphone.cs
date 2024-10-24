using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
    public class IPhone : Devices, I4G, IWifi, IGPRS
    {
        public override void Hoatdong()
        {
            UsingGSM();
            UsingGPRS();
            UsingWifi();
            Using4G();
        }

        public void Using4G()
        {
            Console.WriteLine($"{DeviceName} is using 4G.");
        }

        public void UsingWifi()
        {
            Console.WriteLine($"{DeviceName} is using WiFi.");
        }

        public void UsingGPRS()
        {
            Console.WriteLine($"{DeviceName} is using GPRS.");
        }
    }

}