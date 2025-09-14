using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Trapeze : Triangle
    {
        private double _d;
        public double D
        {
            get => _d;
            set => _d = value > 0 ? value : throw new ArgumentException("Side must be positive");
        }

        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
        {
            D = d;
        }


        public override double GetArea()
        {
            double h = Math.Sqrt(Math.Pow(C, 2) - Math.Pow(((B - A) + D) / 2, 2)); 
            return ((A + B) / 2) * h;
        }

        public override double GetPerimeter() => A + B + C + D;

        public bool ValidateD() => D > 0;
    }
}
