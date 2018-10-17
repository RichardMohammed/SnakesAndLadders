using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace RM.SnakesAndLadders.Tests
{
    public class BoardTests
    {
        [Fact]
        public void Winner_Can_BeFound()
        {
            var token = new Token("Player 1");
            var gameBoard = new Board(new List<Token>{token });
            token.SquarePosition = 100;

            var playerWins = gameBoard.WinnerFound();

            Assert.True(playerWins);
            Assert.True(gameBoard.Status == "GAME OVER");
        }

        [Fact]
        public void Player_Does_Not_Win_If_Not_Square100()
        {
            var token = new Token("Player 1");
            var gameBoard = new Board(new List<Token> { token });
            token.SquarePosition = 99;

            var playerWins = gameBoard.WinnerFound();

            Assert.True(!playerWins);
            Assert.True(gameBoard.Status == "PLAYING");
        }
    }
}
