using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace RM.SnakesAndLadders.Tests
{
    public class TokenTests
    {
        public readonly ITestOutputHelper _output;
        public TokenTests(ITestOutputHelper output)
        {
           _output = output;
        }

        [Fact]
        public void Token_Can_Move()
        {
            var token = new Token("Player 1"); // position defaults to 1
            var oldPosition = token.SquarePosition;
            var newRoll = Dice.Instance.Roll();
            var newPosition = token.MoveToSquare(newRoll);

            Assert.True(newPosition > oldPosition);

            _output.WriteLine(oldPosition.ToString());
            _output.WriteLine(newRoll.ToString());
            _output.WriteLine(newPosition.ToString());
        }
    }
}
