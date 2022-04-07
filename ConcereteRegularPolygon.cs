using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class ConcereteRegularPolygon
    {
        public int Sides { get; }
        public int Length { get; }

        public ConcereteRegularPolygon(int sides, int length)
        {
            Sides = sides;
            Length = length;
        }

        public double GetPerimeter()
        {
            return Sides * Length;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
