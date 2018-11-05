using System.Collections.Generic;

namespace RM.SnakesAndLadders.GameUI
{
    public class Application : IApplication
    {
        private readonly IBoard _board;

        public Application(List<string> playerNames)
        {
            var playerTokens = new List<IToken>();
            playerNames.ForEach(p => playerTokens.Add(new Token(p)));
            _board = new Board(playerTokens);
        }

        public void Run()
        {
            _board.PlayGame();
        }

    }
}
