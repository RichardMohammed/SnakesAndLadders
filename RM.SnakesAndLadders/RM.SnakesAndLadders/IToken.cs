namespace RM.SnakesAndLadders
{
    public interface IToken
    {
        int SquarePosition { get; }
        string PlayerName { get; set; }
        int MoveToSquare(int diceRoll);
    }
}