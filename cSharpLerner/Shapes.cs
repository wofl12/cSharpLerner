using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpLerner
{
    public abstract class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape Created");
        }
        public abstract void Draw();
        public abstract double Area();
        public abstract double Perimeter();


    }

    public class Triangle : Shape
    {
        private readonly double ab;
        private readonly double bc;
        private readonly double ca;

        public Triangle(double ab, double bc, double ca)
        {
            this.ab = ab;
            this.bc = bc;
            this.ca = ca;
            Console.WriteLine("Triangle created");
        }



        public override double Area()
        {
            double s = (ab + bc + ca) / 2;
            return Math.Sqrt(s * (s - ab) * (s - bc) * (s - ca));
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing TriAngle");
        }

        public override double Perimeter()
        {
            return ab + bc + ca;
        }
    }

    public class Ractangle : Shape
    {
        private readonly double width;
        private readonly double height;

        public Ractangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            Console.WriteLine("Rectangle created");
        }
        public override double Area()
        {
            return width * height;
        }

        public override void Draw()
        {
            Console.WriteLine("Rectangle drawed");
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }
    }
}
