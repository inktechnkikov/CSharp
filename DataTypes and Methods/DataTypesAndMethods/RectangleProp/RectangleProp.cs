using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleProp
{
    class RectangleProp
    {
        static void Main()
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            RectanglePerimeter(w,h);
            RectangleArea(w, h);
            RectangleDiagonal(w, h);
        }
        public static void RectanglePerimeter(double width,double height)
        {
           
            double perimeter = 2 * (width + height);
            Console.WriteLine(perimeter);
        }
        public static void RectangleArea(double width,double height)
        {
            double area = width * height;
            Console.WriteLine(area);
        }
        public static void RectangleDiagonal(double width,double height)
        {
            double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(height, 2));
            Console.WriteLine(diagonal);
        }
    }
}
