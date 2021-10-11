using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurer.Models
{
    class Rectangle : Shape
    { 
        public override decimal GetArea()
        {
            return Height * Width;
        }

        public Rectangle(int height, int width) : base(height, width)
        {
        }
    }
}
