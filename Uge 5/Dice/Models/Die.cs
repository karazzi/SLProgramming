using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice.Models
{
    class Die
    {
        private static Random _rand;

        private int _value;

        public Die()
        {
            _value = new int();
            _rand = new Random();
        }

        public void Roll()
        {
            _value = _rand.Next(1, 7);
        }

        public int GetValue()
        {
            return _value;
        }
    }
}
