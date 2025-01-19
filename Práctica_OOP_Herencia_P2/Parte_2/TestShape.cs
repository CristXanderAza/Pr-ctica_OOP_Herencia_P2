using Práctica_OOP_Herencia_P2.Parte_2.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica_OOP_Herencia_P2.Parte_2
{
    public class TestShape
    {
        public static void Execute()
        {
            Shape[] shapes = _getShapes();
            double[] surfaces = _getSurfaces(shapes);
            foreach (double surface in surfaces)
            {
                Console.WriteLine(surface);

            }
        }

        private static Shape[] _getShapes()
        {
            Shape[] _shapes = {
                new Circle(5),
                new Rectangule(5, 4),
                new Triangule(9, 7),
                new Circle(9),
                new Rectangule(12, 24),
                new Triangule(4, 2)
            };
            return _shapes;
        }

        private static double[] _getSurfaces(Shape[] shapes)
        {
            var surfaces = new double[shapes.Length];
            for(int i = 0; i < shapes.Length; i++)
            {
                surfaces[i] = shapes[i].CalculateSurface();
            }
            return surfaces;
        }
    }
}
