using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_OOP_Herencia_P2.Parte_2.Domain
{
    public class Rectangule : Shape
    {
        public Rectangule(double h,  double w) : base(h, w) { }

        public override double CalculateSurface()
            => Heigth * Width;
    }
}
