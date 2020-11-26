using DeckOfCards.TheGame;
using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            /*------------Program starts---------*/
            Console.WriteLine("Hello!");
            IGame game = new Game();
            game.NewGame();
        }
    }
}
