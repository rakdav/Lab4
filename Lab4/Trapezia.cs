using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Trapezia:Figure
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public double H { get; set; }
        public Trapezia(double a, double b, double c, double d, double h)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            H = h;
        }
        public override double Area()
        {
            return (A+B)*H/2;
        }
        public override double Perimetr()
        {
            return A + B + C + D;
        }
        public override string Print()
        {
            return $"Площадь трапеции {Area():F2}," +
                $" периметр {Perimetr():F2}";
        }
    }
}
