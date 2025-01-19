using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_OOP_Herencia_P2.Parte_2.Domain
{
    public abstract class Shape
    {
        public double Heigth { get; set; }
        public double Width { get; set; }

        public Shape(double heigth, double width)
        {
            Heigth = heigth;
            Width = width;
        }

        public abstract double CalculateSurface();
    }
}
