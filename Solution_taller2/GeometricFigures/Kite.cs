using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Kite : Rhombus
    {
        private double _b;
        public double B
        {
            get => _b;
            set => _b = value > 0 ? value : throw new ArgumentException("Side must be positive");
        }

        public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
        {
            B = b;
        }


        public override double GetArea() => (D1 * D2) / 2;
        public override double GetPerimeter() => 2 * (A + B);

        public bool ValidateB() => B > 0;
    }
}
