using System;
using static DeckOfCards.TheGame.Constants;

namespace DeckOfCards.TheGame
{
    class Game:IGame
    {
        private readonly Deck _deck;

        public Game()
        {
            this._deck = new Deck();
        }

        public void NewGame()
        {
            Console.WriteLine(Message.NewGame);
            //Shuffle the deck for every new game.
            _deck.Shuffle();
            this.PlayGame();
        }

        
        public void PlayGame()
        {
            //Allow user to choose an opion
            foreach(string gameOptions in Message.GameOptions)
                Console.WriteLine(gameOptions);
            int choice = -1;
            Int32.TryParse(Console.ReadLine(), out choice);
            switch (choice)
            {
                case Constants.Option.DrawCard:
                    int index = -1;
                    Card card = Draw(out index);
                    if (card == null)
                        RestartGame();
                    else
                        GamePostCardDraw(card, index);
                    break;
                case Constants.Option.ShuffleDeck:
                    Console.WriteLine(Message.DeckShuffling);
                    _deck.Shuffle();
                    Console.WriteLine(Message.DeckShuffled);
                    Console.WriteLine("First card in deck:" + this._deck.GetCards()[0]);
                    this.PlayGame();
                    break;
                case Constants.Option.RestartGame:
                    Console.WriteLine(Message.GameEnded);
                    RestartGame();
                    break;
                case Constants.Option.ExitGame:
                    Console.WriteLine(Message.GameEnded);
                    return;
                default:
                    Console.WriteLine("Please chose from given options...");
                    this.PlayGame();
                    break;
            }
        }


        public Card Draw(out int index)
        {
            Random rand = new Random();
            Card card = null;
            //Randomly chose a card from the deck.
            index = rand.Next(0, this._deck.GetCards().Count);
            int cardSuit = (int)this._deck.GetCards()[index].CardSuit;
            int cardValue = (int)this._deck.GetCards()[index].CardValue;
            try
            {
                card = new Card(cardSuit, cardValue);
            }
            catch (Exception e)
            {
                Console.WriteLine(Message.ErrorMessage+e);
            }
            return card;
        }

        public bool GamePostCardDraw(Card card, int index)
        {
            bool allCardsDrawn = false; //Keep a check if all cards are exhausted.
            if (this._deck.GetCards().Count > 0)
                this._deck.GetCards().RemoveAt(index);
            else
                allCardsDrawn = true;

            Console.WriteLine("Drawn : " + card.ToString());
            
            //Console.WriteLine("Number of cards left in deck:" + this._deck.GetCards().Count);

            if (allCardsDrawn)
            {
                //If all cards exhaust, start a new game
                Console.WriteLine(Message.AllCardsExhausted);
                this.RestartGame();
            }
            else
                this.PlayGame();
            return allCardsDrawn;
        }

        public void RestartGame()
        {
            this.NewGame();
        }
    }

}

