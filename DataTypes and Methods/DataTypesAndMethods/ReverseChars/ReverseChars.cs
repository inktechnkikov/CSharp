using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseChars
{
    class ReverseChars
    {
        static void Main()
        {
            int n = 3;
            char[] box = new char[n];
            for (int i = 0; i < box.Length; i++)
            {
                char letters = char.Parse(Console.ReadLine());
                box[i] += letters;
            }
            Array.Reverse(box);
            Console.Write(box);
        }
    }
}
