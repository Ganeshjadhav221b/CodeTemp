namespace DeckOfCards.TheGame
{
    interface IGame
    {
        void NewGame();
        void PlayGame();
        void RestartGame();
        bool GamePostCardDraw(Card card, int index);

    }
}
