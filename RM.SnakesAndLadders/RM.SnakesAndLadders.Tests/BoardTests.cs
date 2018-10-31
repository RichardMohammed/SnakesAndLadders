using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace RM.SnakesAndLadders.Tests
{
    public class BoardTests
    {
        public readonly ITestOutputHelper Output;

        public BoardTests(ITestOutputHelper output)
        {
            Output = output;
        }

        [Fact]
        public void Winner_Can_BeFound()
        {
            var token = new Token("Player 1");
            var gameBoard = new Board(new List<Token>{token });

            while (token.SquarePosition != 100)
            {
                token.MoveToSquare(3);
            }

            var playerWins = gameBoard.WinnerFound();

            Assert.True(playerWins);
            Assert.True(gameBoard.Status == PlayStatus.Over);
        }

        [Fact]
        public void Player_Does_Not_Win_If_Not_Square100()
        {
            var token = new Token("Player 1");
            var gameBoard = new Board(new List<Token> { token });
            var playerWins = gameBoard.WinnerFound();

            Assert.True(!playerWins);
            Assert.True(gameBoard.Status == PlayStatus.Playing);
        }

        [Fact]
        public void Game_Can_Eventually_BeWon()
        {
            var player1Token = new Token("Player 1");
            var gameBoard = new Board(new List<Token> { player1Token });
            var playerWins = false;

            while (!playerWins)
            {
                player1Token.MoveToSquare(Dice.Instance.Roll());
                playerWins = gameBoard.WinnerFound();
                Output.WriteLine(player1Token.SquarePosition.ToString());
            }

            Assert.True(playerWins);
            Assert.True(gameBoard.Status == PlayStatus.Over);
        }

    }
}
