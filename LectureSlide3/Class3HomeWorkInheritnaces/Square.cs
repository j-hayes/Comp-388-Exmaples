namespace Class3HomeWorkInheritnaces
{
    public class Square : Shape
    {
        public Square() : base()
        {
        }

        public Square(double x) : base(x, 0)
        {
           
        }

        public override double getArea()
        {
            return x*x;
        }
    }
}