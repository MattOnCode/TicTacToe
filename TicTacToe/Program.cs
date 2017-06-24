using System;

namespace TicTacToe {
    class Program {

        [STAThread]
        static void Main(string[] args) {
            string[,] TicTacToeBoard = new string[3, 3]; // Creates a new board
            IPlayer player1; // Declares player 1
            IPlayer player2; // Declares player 2

            GameEngine gameEngine = new GameEngine(); // Creates a new game engine instance
            GameVisualizer gameVisualizer = new GameVisualizer(); // Creates a new game visualizer instance
            GameManager gameManager = new GameManager(gameVisualizer, gameEngine); // Creates a new game manager instance

            gameVisualizer.printInstructions(); // Prints the instructions

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
                Console.WriteLine(); // Blank line
                Console.WriteLine("That is not a valid option");
            }

            gameManager.PlayGame(TicTacToeBoard, player1, player2); // Starts a new game

        }
    }
}
