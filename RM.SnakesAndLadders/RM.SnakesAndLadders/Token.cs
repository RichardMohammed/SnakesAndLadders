using System;

namespace RM.SnakesAndLadders
{
    public class Token
    {
        public bool IsWinner;
        public string PlayerName;
        public int SquarePosition { get; private set; }

        public Token(string playerName)
        {
            PlayerName = playerName;
            SquarePosition = 1;
            IsWinner = false;
        }

        public int MoveToSquare(int diceRoll)
        {
            if (diceRoll < 1 || diceRoll > 6)
                return SquarePosition;

            SquarePosition = SquarePosition + diceRoll < 101 ? SquarePosition + diceRoll : SquarePosition;
            return SquarePosition;
        }
    }
}
