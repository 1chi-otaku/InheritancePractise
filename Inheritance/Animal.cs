using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Animal
    {
        protected string name { get; set; }

        public Animal() : this("N/A") { }

        public Animal(string name)
        {
            this.name = name;
        }

        public abstract void Print();

        public override string ToString()
        {
            return $"Name - {name}";
        }
    }


    class Tiger : Animal
    {
        int number_of_strips;

        public Tiger(string name, int number_of_strips) : base(name)
        {
            this.number_of_strips = number_of_strips;
        }

        public override void Print()
        {
            Console.WriteLine("Class - Tiger");
            Console.WriteLine("Name - " + name);
            Console.WriteLine("Number of strips - " + number_of_strips);
        }
        public override string ToString()
        {
            return base.ToString() + $"Number of strops - {number_of_strips}";
        }
    }

    class Crocodile : Animal
    {
        int scale_hardness;

        public Crocodile(string name, int scale_hardness) : base(name)
        {
            this.scale_hardness = scale_hardness;
        }

        public override void Print()
        {
            Console.WriteLine("Class - Crocodile");
            Console.WriteLine("Name - " + name);
            Console.WriteLine("Scale hardness - " + scale_hardness);
        }
        public override string ToString()
        {
            return base.ToString() + $"Scale hardness - {scale_hardness}";
        }
    }

    class Kangaroo : Animal
    {
        double marsupium_volume;
        public Kangaroo(string name, double marsupium_volume) : base(name)
        {
            this.marsupium_volume = marsupium_volume;
        }

        public override void Print()
        {
            Console.WriteLine("Class - Kangaroo");
            Console.WriteLine("Name - " + name);
            Console.WriteLine("Marsupium Volume - " + marsupium_volume);
        }
        public override string ToString()
        {
            return base.ToString() + $"Marsupium Volume - {marsupium_volume}";
        }
    }
}
