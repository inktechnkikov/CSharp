using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class DayOfWeek
    {
        static void Main()
        {
            string[] Days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());
            if(day >=1 && day <= 7)
            {
                Console.WriteLine(Days[day-1]);
            }
            else
            {
                Console.WriteLine("Invalid day");
            }
        }
    }
}
