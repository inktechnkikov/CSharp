using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_exampl
{
    class Dog
    {
        public string Name { get; set; }
        public double Age { get; set; }
        public string Breed { get; set; }

        public Dog(string name,double age,string breed)
        {
            this.Name = name;
            this.Age = age;
            this.Breed = breed;
        }
        public override string ToString()
        {
            return String.Format("Name - {0};Age - {1};Breed - {2}", this.Name, this.Age, this.Breed);

        }
    }
            
}
