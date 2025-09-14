using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Rhombus : Square
    {
        private double _d1;
        private double _d2;

        public double D1
        {
            get => _d1;
            set => _d1 = value > 0 ? value : throw new ArgumentException("Diagonal must be positive");
        }

        public double D2
        {
            get => _d2;
            set => _d2 = value > 0 ? value : throw new ArgumentException("Diagonal must be positive");
        }

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }

        public override double GetArea() => (D1 * D2) / 2;
        public override double GetPerimeter() => 4 * A;

        public bool ValidateD1() => D1 > 0;
        public bool ValidateD2() => D2 > 0;
    }
}
