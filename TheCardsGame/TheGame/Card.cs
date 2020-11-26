
using static DeckOfCards.TheGame.Constants;

namespace DeckOfCards.TheGame
{
    class Card
    {
        private readonly CardSuit _suit;
        private readonly CardValue _value;

        public Card(int suit, int value)
        {
            this._suit = (CardSuit)(suit);
            this._value = (CardValue)(value);
        }

        public CardSuit CardSuit
        {
            get { return _suit; }
        }

        public CardValue CardValue
        {
            get { return _value; }
        }

        public override string ToString()
        {
            return this._value+" of "+this._suit;
        }

    }
}
