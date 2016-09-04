using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertElementsInArr
{
    class insertElementsInArr
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] ArrSize = new int[n];
            for (int i = 0; i < ArrSize.Length; i++)
            {
                Console.WriteLine("insert number:");
                ArrSize[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(String.Join(", ",ArrSize));
        }
    }
}
