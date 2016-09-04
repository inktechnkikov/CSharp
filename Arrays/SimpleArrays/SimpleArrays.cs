using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleArrays
{
    class SimpleArrays
    {
        static void Main()
        {
            int[] arr = new int[5];
            arr[0] = 3;
            arr[3] = 1;
            arr[1] = 2;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
