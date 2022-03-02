using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Circle:Figure
    {
        public double R { get; set; }
        public Circle(double r)
        {
            R = r;
        }
        public override double Area()
        {
            return Math.PI*R*R;
        }
        public override double Perimetr()
        {
            return 2*Math.PI * R;
        }
        public override string Print()
        {
            return $"Площадь окружности {Area():F2},\n" +
                $" периметр {Perimetr():F2}";
        }
    }
}
