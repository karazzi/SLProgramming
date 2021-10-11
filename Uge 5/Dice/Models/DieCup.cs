using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.Models
{
    class DieCup
    {
        private Die d1;
        private Die d2;

        public DieCup()
        {
            d1 = new Die();
            d2 = new Die();
        }

        public void Roll()
        {
            d1.Roll();
            d2.Roll();
        }

        public int GetValue()
        {
            return d1.GetValue() + d2.GetValue();
        }

        public string ToString()
        {
            return $"{d1.GetValue()} + {d2.GetValue()} = {GetValue()}";
        }
    }
}
