using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvning.Models
{
    class Child : Parent
    {
        public void Display()
        {
            Console.WriteLine("Dette er underklassen.");
        }
    }
}
