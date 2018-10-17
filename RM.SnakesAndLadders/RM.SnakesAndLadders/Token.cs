using System;

namespace RM.SnakesAndLadders
{
    public class Token
    {
        public int SquarePosition { get; set; }
        public bool IsWinner;
        public string PlayerName;

        public Token(string playerName)
        {
            PlayerName = playerName;
            SquarePosition = 1;
            IsWinner = false;
        }

        public int MoveToSquare(int diceRoll)
        {
            if(SquarePosition + diceRoll < 101)
            {
                SquarePosition += diceRoll;
            }

            return SquarePosition;
        }
    }
}
