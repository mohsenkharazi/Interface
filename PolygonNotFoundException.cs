using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class PolygonNotFoundException : Exception
    {
        public PolygonNotFoundException()
        {
        }

        public PolygonNotFoundException(string message) 
            : base(message)
        {
        }

        public PolygonNotFoundException(string message, Exception inner) 
            : base(message, inner)
        {
        }
    }
}
