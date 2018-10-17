using System;
using System.Collections.Generic;

namespace RM.SnakesAndLadders.Game
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1Token = new Token("Player 1");
            var player2Token = new Token("Player 2");
            var players = new List<Token> { player1Token, player2Token };
            var gameBoard = new Board(players);
            var playerWins = false;
            var playerIndex = 0;
            var message = "Playing";

            while (!playerWins)
            {
                var currentPlayer = players[playerIndex];
                Console.WriteLine($"{currentPlayer.PlayerName}'s turn. {Environment.NewLine} Press Enter to Roll your dice.");
                var key = Console.ReadKey().Key.ToString();

                if (key == "Enter")
                {
                    var roll = Dice.Instance.Roll();
                    Console.WriteLine($"You have rolled a {roll}");

                    currentPlayer.MoveToSquare(roll);
                    Console.WriteLine($"You are now in position {currentPlayer.SquarePosition.ToString()}");

                    playerWins = gameBoard.WinnerFound();
                    message = gameBoard.Message;

                    if (playerIndex < players.Count - 1)
                    {
                        playerIndex++;
                    }
                    else
                    {
                        playerIndex = 0;
                    }
                }
            }

            Console.WriteLine(gameBoard.Message);
            Console.ReadLine();
        }
    }
}
