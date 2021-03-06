using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Triangle : AbstractRegularPolygon
    {
        public Triangle(int length) : base(3, length)
        {

        }
        public override double GetArea()
        {
            return Length * Length * Math.Sqrt(3) / 4;
        }
    }
}
