using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    
        public class Circle : GeometricFigure
        {
            private double _r;
            public double R
            {
                get => _r;
                set => _r = value > 0 ? value : throw new ArgumentException("Radius must be positive");
            }

            public Circle(string name, double r) : base(name)
            {
                R = r;
            }

            public override double GetArea() => Math.PI * Math.Pow(R, 2);
            public override double GetPerimeter() => 2 * Math.PI * R;

            public bool ValidateR() => R > 0;
        }
    }


