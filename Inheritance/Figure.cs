using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class Figure
    {
        public abstract double CalculateArea();
        public abstract void Print();
    }
    

    class Rectangle : Figure
    {

        double length;
        double width;
        public Rectangle():this(0,0) { }
        public Rectangle(double x, double y)
        {
            length = x;
            width = y;
        }
        public override double CalculateArea()
        {
            return length * width;
        }
        public override void Print()
        {
            Console.WriteLine("Class - Rectangle");
            Console.WriteLine("length - " + length + "\twidth - " + width);
            Console.WriteLine("Area - " + CalculateArea());
        }
    }

    class Circle: Figure
    {
        double radius;
        public Circle():this(0) { }
        public Circle(double rad)
        {
            radius = rad;
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius,2);
        }
        public override void Print()
        {
            Console.WriteLine("Class - Circle");
            Console.WriteLine("radius - " + radius);
            Console.WriteLine("Area - " + CalculateArea());
        }
    }

    class RightTriangle: Figure
    {
        double height;
        double leg;
        public RightTriangle() : this(0,0) { }
        public RightTriangle(double h, double l)
        {
            height = h;
            leg = l;
        }
        public override double CalculateArea()
        {
            return 0.5 * (height * leg);
        }
        public override void Print()
        {
            Console.WriteLine("Class - Right Triangle");
            Console.WriteLine("height - " + height + "\tleg - " + leg);
            Console.WriteLine("Area - " + CalculateArea());
        }

    }

    class Trapezoid: Figure
    {
        double len_base1;
        double len_base2;
        double height;
        public Trapezoid() : this(0, 0,0) { }
        public Trapezoid(double b1, double b2, double h)
        {
            height = h;
            len_base1  = b1;
            len_base2 = b2;
        }
        public override double CalculateArea()
        {
            return (len_base1 + len_base2)/2 * height;
        }
        public override void Print()
        {
            Console.WriteLine("Class - Trapezoid");
            Console.WriteLine("height - " + height + "\tlen base 1 - " + len_base1 + "\tlen base 2 - " + len_base2);
            Console.WriteLine("Area - " + CalculateArea());
        }
    }
}
