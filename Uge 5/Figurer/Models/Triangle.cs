using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurer.Models
{
    class Triangle : Shape
    {
        
        public override decimal GetArea()
        {
            return Height / 2 * Width;
        }

        public Triangle(int height, int width) : base(height, width)
        {
        }
    }
}
