namespace GeometricFigures
{
    public abstract class GeometricFigure
    {
        public string Name { get; set; }

        public GeometricFigure(string name)
        {
            Name = name;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return $"{Name,-12} => Area.....: {GetArea(),10:0.00000}    Perimeter: {GetPerimeter(),10:0.00000}";
        }
    }
}
