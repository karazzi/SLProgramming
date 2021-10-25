using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;

namespace Krig.Models
{
    class Card
    {
        public int Value { get; private set; }
        public SuitEnum Suit { get; private set; }

        public Card(int value, SuitEnum suit)
        {
            Value = value;
            Suit = suit;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            switch (Value)
            {
                case 1:
                    sb.Append("Ace");
                    break;
                case 11:
                    sb.Append("Jack");
                    break;
                case 12:
                    sb.Append("Queen");
                    break;
                case 13:
                    sb.Append("King");
                    break;
                default:
                    sb.Append(Value);
                    break;
            }

            sb.Append($" of {Suit}");
            return sb.ToString();
        }

        public enum SuitEnum
        {
            Hearts,
            Diamonds,
            Clubs,
            Spades
        }
    }
}
