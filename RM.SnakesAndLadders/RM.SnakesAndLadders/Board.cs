using System;
using System.Collections.Generic;
using System.Text;

namespace RM.SnakesAndLadders
{
    public class Board
    {
        private List<Token> _playerTokens;
        public string Status;
        public string Message;

        public Board(List<Token> playerTokens)
        {
            _playerTokens = playerTokens;
            Status = "PLAYING";
        }
        
        public bool WinnerFound()
        {
            foreach(var token in _playerTokens)
            {
                if(token.SquarePosition == 100)
                {
                    token.IsWinner = true;
                    Status = "GAME OVER";
                    Message = $"{token.PlayerName} Wins!!!";
                    return true;
                }
            }

            return false;
        }

        public void SetTokenPositionOnScreen(int squareNumber)
        {
            // We can use this to move the tokens across the board in the GUI
            // based on the size of the board and the position of the squares on screen
        }

    }
}
