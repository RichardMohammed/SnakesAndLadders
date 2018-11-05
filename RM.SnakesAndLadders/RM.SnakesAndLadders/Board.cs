using System;
using System.Collections.Generic;

namespace RM.SnakesAndLadders
{
    public class Board : IBoard
    {
        private readonly List<IToken> _playerTokens;
        public string Message;
        public PlayStatus Status;

        public Board(List<IToken> playerTokens)
        {
            _playerTokens = playerTokens;
            Status = PlayStatus.Playing;
            Message = "In play";
        }
        
        public bool WinnerFound()
        {
            foreach(var token in _playerTokens)
            {
                if (token.SquarePosition != 100) continue;

                Status = PlayStatus.Over;
                Message = $"{token.PlayerName} Wins!!!";
                return true;
            }

            return false;
        }

        public void PlayGame()
        {
            var playerIndex = 0;

            while (!WinnerFound())
            {
                var currentPlayer = _playerTokens[playerIndex];
                Console.WriteLine($"{currentPlayer.PlayerName}'s turn. {Environment.NewLine} Press Enter to Roll your dice.");
                var key = Console.ReadKey().Key.ToString();

                if (key != "Enter") continue;

                var roll = Dice.Instance.Roll();
                Console.WriteLine($"You have rolled a {roll}");

                currentPlayer.MoveToSquare(roll);
                Console.WriteLine($"You are now in position {currentPlayer.SquarePosition.ToString()}");

                if (playerIndex < _playerTokens.Count - 1)
                {
                    playerIndex++;
                }
                else
                {
                    playerIndex = 0;
                }
            }

        }
    }
}
