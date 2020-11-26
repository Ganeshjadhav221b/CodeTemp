using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards.TheGame
{
    class Constants
    {
        public enum CardSuit
        {
            Clubs = 0,
            Diamonds = 1,
            Hearts = 2,
            Spades = 3,
        }

        public enum CardValue
        {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 11,
            Queen = 12,
            King = 13
        }

        public class Message
        {
            public static List<string> GameOptions = new List<string>();
            public static string DeckShuffling = "A'ight, shuffling the deck for you...";
            public static string DeckShuffled = "Deck is shuffled, good to go!";
            public static string GameEnded = "--------------------------Game has ended -------------------------------";
            public static string ErrorMessage = "Something went wrong from our end....";
            public static string AllCardsExhausted = "All cards from the deck exhausted...";
            public static string NewGame = "Starting a new game for you :) \nLet the game begin!";
            static Message()
            {
                GameOptions.Add("Press 1 to draw a new card");
                GameOptions.Add("Press 2 to shuffle the deck");
                GameOptions.Add("Press 3 to restart");
                GameOptions.Add("Press 9 to exit the game");
                GameOptions.Add("What would you like to do?");
            }
        }

        public class Option
        {
            public const int DrawCard = 1;
            public const int ShuffleDeck = 2;
            public const int RestartGame = 3;
            public const int ExitGame = 9;
        }
    }
}
