using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Human
    {
        protected string Name { get; set; }
        protected int Age { get; set; }

        public Human() : this("Human", 0) { }
        public Human(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public abstract void Print();
        public override string ToString()
        {
            return $"Name: {Name}\tAge: {Age}\n";
        }
    }

    class Builder : Human
    {
        string Material { get; set; }
        public Builder(string name, int age, string material):base(name, age)
        {
            Material = material;
        }
        public override void Print()
        {
            Console.WriteLine("Class - Builder\n" + base.ToString() + $"\tMaterial: {Material}\n");
        }
        public override string ToString()
        {
            return base.ToString() + $"Class - Builder\nMaterial: {Material}\n";
        }
    }

    class Sailor: Human
    {
        uint Number_of_shipments { get; set; }
        public Sailor(string name, int age, uint nofshipments) : base(name, age)
        {
            Number_of_shipments = nofshipments;
        }
        public override void Print()
        {
            Console.WriteLine("Class - Sailor\n" + base.ToString() + $"\tNumber_of_shipments: {Number_of_shipments}\n");
        }
        public override string ToString()
        {
            return base.ToString() + $"Class - Sailor\nNumber_of_shipments: {Number_of_shipments}\n";
        }
    }

    class Pilot : Human
    {
        uint Experience { get; set; }
        public Pilot(string name, int age, uint experient) : base(name, age)
        {
            Experience = experient;
        }
        public override void Print()
        {
            Console.WriteLine("Class - Pilot\n" + base.ToString() + $"\tExperience: {Experience}\n");
        }
        public override string ToString()
        {
            return base.ToString() + $"Class - Pilot\nExperience: {Experience}\n";
        }
    }

}
