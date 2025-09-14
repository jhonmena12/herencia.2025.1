using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Rectangle : Square
    {
        private double _b;
        public double B
        {
            get => _b;
            set => _b = value > 0 ? value : throw new ArgumentException("Side must be positive");
        }

        public Rectangle(string name, double a, double b) : base(name, a)
{
            B = b;
        }


        public override double GetArea() => A * B;
        public override double GetPerimeter() => 2 * (A + B);

        public bool ValidateB() => B > 0;
    }
}
