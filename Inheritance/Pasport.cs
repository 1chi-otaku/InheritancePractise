using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Passport
    {
        protected string Full_name;
        protected int Age;
        protected string Number_of_passport;

        public Passport(string full_name, int age, string number_of_passport)
        {
            Full_name = full_name;
            Age = age;
            Number_of_passport = number_of_passport;
        }
        public Passport():this(null, 0,null) { }

        public void Print()
        {
            Console.WriteLine("Full name - " + Full_name);
            Console.WriteLine("Age - " + Age);
            Console.WriteLine("Number_of_passport - " + Number_of_passport);
        }
        public override string ToString()
        {
            return $"Full Name - {Full_name}\nAge - {Age}\nPassport Number - {Number_of_passport}";
        }

    }


    class ForeignPassport : Passport
    {
        string Country;
        string Visa;
        string Number_of_ForeignPassport;
        public ForeignPassport(string full_name, int age, string number_of_passport, string country, string visa, string number_of_ForeignPassport):base(full_name,age,number_of_passport)
        {
            Country = country;
            Visa = visa;
            Number_of_ForeignPassport = number_of_ForeignPassport;
        }
        new public void Print()
        {
            base.Print();
            Console.WriteLine("Country - " + Country);
            Console.WriteLine("Visa - " + Visa);
            Console.WriteLine("Foreign Passport Number - " + Number_of_ForeignPassport);
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCountry - {Country}\nVisa - {Visa}\nForeign Passport Number - {Number_of_passport}\n";
        }

    }
}
