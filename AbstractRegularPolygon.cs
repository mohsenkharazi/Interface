using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public abstract class AbstractRegularPolygon
    {
        public int Sides { get; }
        public int Length { get; }

        public AbstractRegularPolygon(int sides, int length)
        {
            Sides = sides;
            Length = length;
        }

        public double GetPerimeter()
        {
            return Sides * Length;
        }

        public abstract double GetArea();
    }
}
