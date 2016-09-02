using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumber
{
    class SpecialNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                int digits = i;
                while(digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits = digits / 10;
                }
                bool speacial = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 10);
                Console.WriteLine("{0} -> {1}",i,speacial);
            }
        }
    }
}
