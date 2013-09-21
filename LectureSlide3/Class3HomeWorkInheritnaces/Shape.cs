using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class3HomeWorkInheritnaces
{
    public class Shape
    {
        protected double x;
        protected double y;

        public Shape()
        {
        }

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double getArea()
        {
            return x * y;
        }

    }
}
