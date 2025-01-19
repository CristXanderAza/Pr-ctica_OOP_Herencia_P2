using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_OOP_Herencia_P2.Parte_2.Domain
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) : base(radius, radius)
        {
            Radius = radius;
        }

        public override double CalculateSurface()
            => 3.1416 * (Radius * Radius);
    }
}
