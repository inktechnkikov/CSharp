using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithClasses
{
    class DemoClasses
    {
        static void Main()
        {
            Building SoftwareUniversity = new Building("15-17 - Tintyava",3,1480.65);
            Building parkHotelMosscow = new Building("10 zh.k.- iztok", 20, 12550.15);
            Console.WriteLine(SoftwareUniversity);
            SoftwareUniversity.Address = "Address changed";
            Console.WriteLine(SoftwareUniversity);
            Console.WriteLine(parkHotelMosscow);
            Building Alyakovo = new Building("zh.k Alyakovo");
            Alyakovo.Floors = 10;
            Console.WriteLine(Alyakovo);
        }
    }
}
