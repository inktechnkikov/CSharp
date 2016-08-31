using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumOfRealNums
{
    class ExactSumOFRealNums
    {
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal sum = 0;
            for (int i = 0; i < n; i++)
            {
                decimal simpleNum = decimal.Parse(Console.ReadLine());
                sum += simpleNum;
            }
            Console.WriteLine(sum);
        }
    }
}
