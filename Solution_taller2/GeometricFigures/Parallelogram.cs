using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    public class Parallelogram : Rectangle
    {
        private double _h;
        public double H
        {
            get => _h;
            set => _h = value > 0 ? value : throw new ArgumentException("Height must be positive");
        }

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            H = h;
        }

        public override double GetArea() => A * H;

        public bool ValidateH() => H > 0;
    }
}
