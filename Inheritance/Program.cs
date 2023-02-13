using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region #1 Создайте класс Human, который будет содержать информацию о человеке.С помощью механизма наследования, реализуйте класс Builder,Sailor,Pilot
            //Human[] ptr = new Human[3];

            //ptr[0] = new Builder("Tom",25,"Wood");
            //ptr[1] = new Sailor("Max", 18, 15);
            //ptr[2] = new Pilot("Alex", 40, 12);

            //foreach(Human h in ptr)
            //{
            //    h.Print();
            //}
            #endregion
            #region #2
            //Passport passport= new Passport("Tom",18,"00000111112222");
            //passport.Print();
            //Console.WriteLine();
            //ForeignPassport foreign = new ForeignPassport("Tom2", 56, "00000111113333", "UK", "Ukraine", "#BC1111000022222");
            //foreign.Print();
            #endregion
            #region #3
            //Animal[] ptr = new Animal[3];

            //ptr[0] = new Tiger ("Tigoro",128);
            //ptr[1] = new Crocodile("Croco", 18);
            //ptr[2] = new Kangaroo("Kann", 25.5);

            //foreach(var item in ptr) {
            //    item.Print();
            //    Console.WriteLine();
            //}
            #endregion
            #region #4

            Figure[] ptr = new Figure[4];
            ptr[0] = new Rectangle(6.5, 2);
            ptr[1] = new Circle(12.2);
            ptr[2] = new Trapezoid(6, 2, 12.2);
            ptr[3] = new RightTriangle(14, 6.2);

            foreach (Figure f in ptr)
            {
                f.Print();
                Console.WriteLine();
            }

            #endregion
        }
    }
}
