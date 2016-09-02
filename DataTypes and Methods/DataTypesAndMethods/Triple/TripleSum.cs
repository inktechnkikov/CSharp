using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triple
{
    class TripleSum
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            for (int i = 0; i <= input-1; i++)
            {
                for (int a = 0; a <= input-1; a++)
                {
                    for (int q = 0; q <=input-1; q++)
                    {
                        char letter = (char)('a' + i);
                        char letter1 = (char)('a' + a);
                        char letter2 = (char)('a' + q);

                        Console.WriteLine("{0}{1}{2}", letter, letter1, letter2);
                    }
                }
            }
        }
    }
}
