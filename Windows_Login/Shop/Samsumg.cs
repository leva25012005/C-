using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop
{
    public class Samsung : Devices
    {
        public override void Hoatdong()
        {
            UsingGSM();  // Only supports GSM
        }
    }
}