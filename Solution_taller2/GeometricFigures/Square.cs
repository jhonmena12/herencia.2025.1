using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigures
{
    
        public class Square : GeometricFigure
        {
            private double _a;
            public double A
            {
                get => _a;
                set => _a = value > 0 ? value : throw new ArgumentException("Side must be positive");
            }

             public Square(string name, double a) : base(name)
             {
               A = a;
             }

        public override double GetArea() => A * A;
            public override double GetPerimeter() => 4 * A;

            public bool ValidateA() => A > 0;
        }
    }


