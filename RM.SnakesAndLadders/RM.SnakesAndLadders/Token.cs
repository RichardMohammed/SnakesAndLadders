namespace RM.SnakesAndLadders
{
    public class Token : IToken
    {
        public int SquarePosition { get; private set; }
        public string PlayerName { get; set; }

        public Token(string playerName)
        {
            PlayerName = playerName;
            SquarePosition = 1;
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
