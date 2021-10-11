using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figurer.Models
{
    abstract class Shape
    {
        public int Height { get; set; }
        public int Width { get; set; }

        protected Shape(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public abstract decimal GetArea();
    }
}
