using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IRegularPolygon
    {
        int Sides { get; set; }
        int Length { get; set; }
        double GetArea();
        double GetPerimeter();
    }
}
