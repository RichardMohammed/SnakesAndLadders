using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace RM.SnakesAndLadders.Tests
{
    public class BoardTests
    {
        public readonly ITestOutputHelper _output;

        public BoardTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Winner_Can_BeFound()
        {
            var token = new Token("Player 1");
            var gameBoard = new Board(new List<Token>{token });
            token.SquarePosition = 100;

            var playerWins = gameBoard.WinnerFound();

            Assert.True(playerWins);
            Assert.True(gameBoard.Status == PlayStatus.Over);
        }

        [Fact]
        public void Player_Does_Not_Win_If_Not_Square100()
        {
            var token = new Token("Player 1");
            var gameBoard = new Board(new List<Token> { token });
            token.SquarePosition = 99;

            var playerWins = gameBoard.WinnerFound();

            Assert.True(!playerWins);
            Assert.True(gameBoard.Status == PlayStatus.Playing);
        }

        [Fact]
        public void Game_Can_Eventually_BeWon()
        {
            var player1Token = new Token("Player 1");
            var player2Token = new Token("Player 2");
            var players = new List<Token> { player1Token, player2Token };
            var gameBoard = new Board(players);
            var playerWins = false;
            var playerIndex = 0;
            while (!playerWins)
            {
                var currentPlayer = players[playerIndex];
                _output.WriteLine($"{currentPlayer.PlayerName}'s turn");

                currentPlayer.MoveToSquare(Dice.Instance.Roll());

                playerWins = gameBoard.WinnerFound();
                var message = gameBoard.Message;

                if(playerIndex < players.Count - 1)
                {
                    playerIndex++;
                }
                else
                {
                    playerIndex = 0;
                }

                _output.WriteLine(currentPlayer.SquarePosition.ToString());
                _output.WriteLine(message);
            }

            Assert.True(playerWins);
            Assert.True(gameBoard.Status == PlayStatus.Over);
        }

    }
}
