using Xunit;
using Xunit.Abstractions;

namespace RM.SnakesAndLadders.Tests
{
    public class TokenTests
    {
        public readonly ITestOutputHelper Output;
        public TokenTests(ITestOutputHelper output)
        {
           Output = output;
        }

        [Fact]
        public void Token_Starts_At_1()
        {
            var token = new Token("PLayer 1");
            Assert.True(token.SquarePosition == 1);
        }

        [Fact]
        public void Token_Can_Move()
        {
            var token = new Token("Player 1"); // position defaults to 1
            var oldPosition = token.SquarePosition;
            var newPosition = token.MoveToSquare(4);

            Assert.True(newPosition > oldPosition);
            Assert.True(newPosition == 5);

            Output.WriteLine(oldPosition.ToString());
            Output.WriteLine(newPosition.ToString());
        }
    }
}
