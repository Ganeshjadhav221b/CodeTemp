using System;
using System.Collections.Generic;

namespace DeckOfCards.TheGame
{
    class Deck
    {
        private readonly List<Card> _cards;

        public Deck()
        {
            this._cards = new List<Card>();
            for (int i = 0; i < 4; i++)         //Suit values 0-3 (0-clubs, 1-diamonds, 2-hearts, 3-spades)
            {
                for (int j = 1; j < 14; j++)    //Card values 1-13 (values ordered from 2 to 10 + honor cards)
                {
                    this._cards.Add(new Card(i, j));
                }
            }
        }

        public void Shuffle()
        {
             Random rand = new Random();
            for (int i = 0; i < _cards.Count; i++)      /*Shuffles all cards by swapping with random card*/
            {
                var temp = _cards[i];
                var index = rand.Next(0, _cards.Count);
                _cards[i] = _cards[index];
                _cards[index] = temp;
            }
        }

        public List<Card> GetCards()
        {
            return this._cards;
        }
    }
}
