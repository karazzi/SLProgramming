﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Krig.Models
{
    class Game
    {
        public Stack<Card> CardDeck { get; set; }

        public Card PlayerOneCard { get; set; }

        public Card PlayerTwoCard { get; set; }

        public int PlayerOneScore { get; set; }

        public int PlayerTwoScore { get; set; }

        public Game()
        {
            CardDeck = new Stack<Card>();
            PlayerOneScore = 0;
            PlayerTwoScore = 0;
            PlayerOneCard = null;
            PlayerTwoCard = null;
        }

        public void FillDeck()
        {
            CardDeck.Clear();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Card card = new Card(j, (Card.SuitEnum)i);
                    CardDeck.Push(card);
                }
            }

            CardDeck = Shuffle(CardDeck);

        }

        public Card SelectCard()
        {
            return CardDeck.Pop();
        }

        private Stack<T> Shuffle<T>(Stack<T> stack)
        {
            Random rng = new Random();
            List<T> list = stack.ToList();
            int n = list.Count();
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return new Stack<T>(list);
        }
    }
}
