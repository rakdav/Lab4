using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Rectangle : Figure
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
           return Width * Height;
        }
        public override double Perimetr()
        {
            return 2 * (Width + Height);
        }
        public override string Print()
        {
            return $"Площадь прямоугольника {Area()},\n" +
                $" периметр {Perimetr()}";
        }
    }
}
