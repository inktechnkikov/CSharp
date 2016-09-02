using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilledSquare
{
    class FilledSquare
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            PrintHeader(input);
            Console.WriteLine();
            for (int body = 1; body < input-1; body++)
            {
                PrintMiddle(input);
            }
            PrintHeader(input);
            Console.WriteLine();

        }
        public static void PrintHeader(int a)
        {
            Console.Write(new string('-', 2 * a));    
        }
        public static void PrintMiddle(int a)
        {
            Console.Write('-');
            for (int i = 0; i <= a-2; i++)
            {
                 Console.Write(@"\/");
            }
            Console.WriteLine("-");
        }
      
    }
}
