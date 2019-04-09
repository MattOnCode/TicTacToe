using System;
using TicTacToe.Game;
using TicTacToe.Player;

namespace TicTacToe {
    class Program {
        static void Main(string[] args) {
            var ticTacToeBoard = new string[3, 3];
            IPlayer player1;
            IPlayer player2; 

            var gameEngine = new GameEngine();
            var gameVisualizer = new GameVisualizer();
            var gameManager = new GameManager(gameVisualizer, gameEngine);

            gameVisualizer.printInstructions();

            // Loops until the player has chosen an option
            while (true) {
                Console.WriteLine("Choose playing mode - 2PLAYER or AI?");
                var mode = Console.ReadLine().ToUpper();
                if (mode.Equals("2PLAYER")) {
                    player1 = new RealPlayer();
                    player2 = new RealPlayer();
                    break;
                } else if (mode.Equals("AI")) {
                    player1 = new RealPlayer();
                    player2 = new AIPlayer();
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("That is not a valid option");
            }

            gameManager.PlayGame(ticTacToeBoard, player1, player2);
        }
    }
}
