using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Octagon : IRegularPolygon
    {
        public int Sides { get; set; }
        public int Length { get; set; }

        public Octagon(int length)
        {
            Sides = 8;
            Length = length;
        }

        public double GetArea()
        {
            return Length * Length * (2 + 2 * Math.Sqrt(2));
        }

        public double GetPerimeter()
        {
            return Sides * Length;
        }
    }
}
