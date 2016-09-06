using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenceArr
{
    class CondecneArr
    {
        static void Main()
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            while(nums.Length > 1)
            {
                int[] res = new int[nums.Length - 1];
                for (int i = 0; i < nums.Length-1; i++)
                {
                    res[i] = nums[i] + nums[i + 1];
                }
                nums = res;
            }
            Console.WriteLine(nums[0]);
        }
    }
}
