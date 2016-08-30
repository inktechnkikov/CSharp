using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_exampl
{
    class Dogexample
    {
        static void Main()
        {
            //Dog poodle = new Dog("Marie", 2,"poodle");
            //Console.WriteLine(poodle);
            //Dog pinscher = new Dog("Jacko", 1.5, "pinsher");
            //Console.WriteLine(pinscher);
            //Dog GermanShepherd = new Dog("Lorean", 2.5, "German Shepherd");
            //Console.WriteLine(GermanShepherd);
            Console.WriteLine("enter dog`s name:");
            string dogName = Console.ReadLine();
            Console.WriteLine("enter dog`s age:");
            double dogAge = double.Parse(Console.ReadLine());
            Console.WriteLine("enter dog`s breed:");
            string dogBreed = Console.ReadLine();
            Dog dogsProp = new Dog(dogName, dogAge,dogBreed);
            Console.WriteLine(dogsProp);

        }
    }
}
