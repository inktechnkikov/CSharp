using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elevator
{
    class Elevator
    {
        static void Main()
        {
            // int elevateN = int.Parse(Console.ReadLine());
            // int capacity = int.Parse(Console.ReadLine());
            // double courses = Math.Ceiling((double)elevateN / capacity);
            // Console.WriteLine("{0}",courses);
            double elevateN = double.Parse(Console.ReadLine());
            double capaxity = double.Parse(Console.ReadLine());
            double courses = ((int)elevateN / capaxity);
            Console.WriteLine("{0}",Math.Ceiling(courses));
        }
    }
}
