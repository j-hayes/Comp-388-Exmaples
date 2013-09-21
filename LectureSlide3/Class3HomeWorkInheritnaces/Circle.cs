using System;

namespace Class3HomeWorkInheritnaces
{
    public class Circle : Shape
    {
        public Circle(): base()
        {
        }

        public Circle(double radius) : base(radius, Math.PI)
        {

        }

        public override double getArea()
        {
            return x*x*y;// pi * r^2
        }
    }
}