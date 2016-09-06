using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class TripleSum
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                int count = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int b=i+1; b <nums.Length; b++)
                {
                    int a = nums[i];
                    int h = nums[b];
                    int sum = a + h;
                    if(nums.Contains(sum))
                    {
                        Console.WriteLine($"{a} + {b} == {sum}");
                    }
                }
            }
            if(count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
