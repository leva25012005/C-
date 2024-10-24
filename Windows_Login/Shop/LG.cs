using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
    public class LG : Devices, IGPRS
    {
        public override void Hoatdong()
        {
            UsingGSM();
            UsingGPRS();
        }

        public void UsingGPRS()
        {
            Console.WriteLine($"{DeviceName} is using GPRS.");
        }
    }
}