using System;

namespace TicTacToe {
    class GameManager {

        // Creates local class variables for other classes
        private readonly GameVisualizer gameVisualizer;
        private readonly GameEngine gameEngine;

        /// <summary>
        /// Constructor for GameManager
        /// </summary>
        /// <param name="argGameVisualizer">Passes in Game Visualizer class</param>
        /// <param name="argGameEngine">Passes in Game Engine class</param>
        public GameManager(GameVisualizer argGameVisualizer, GameEngine argGameEngine) {
            gameVisualizer = argGameVisualizer;
            gameEngine = argGameEngine;
        }

        /// <summary>
        /// Function to start a new game of Tic Tac Toe
        /// </summary>
        /// <param name="TicTacToeBoard">The TicTacToe board</param>
        /// <param name="player1">Player 1</param>
        /// <param name="player2">Player 2</param>
        public void PlayGame(string[,] TicTacToeBoard, IPlayer player1, IPlayer player2) {
            gameVisualizer.InitalizeBoard(TicTacToeBoard); // Creates a new board

            // Loops until the player chooses either X or O
            Console.WriteLine(); // Blank Line, supports all OS
            Console.WriteLine("Player1, Do you wish to be X or O?");
            while (true) {
                var player1Name = Console.ReadLine().ToUpper();
                if (player1Name.ToUpper().Equals("X") || player1Name.ToUpper().Equals("O")) {
                    player1.SetPlayer(player1Name);
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("That is not a valid answer!");
                Console.WriteLine("Player1, Do you wish to be X or O?");
            }
            player2.SetPlayer(player1.GetPlayer().ToUpper().Equals("X") ? "O" : "X"); // Automatically set the other player to the opposite
            Console.Clear(); // Clears console

            var Winner = string.Empty; // Resets winner
            var currentPlayer = player1; // Set's player 1to play first

            // The game will continue to play until there's a winner
            while (Winner.Equals(string.Empty)) {

                gameVisualizer.PrintTicTacToeBoard(TicTacToeBoard); // Prints out the board
                Console.WriteLine(); // Blank Line
                Console.WriteLine("It's player 1's Turn!");
                player1.Play(TicTacToeBoard); // Player 1's Turn
                Winner = gameEngine.CheckForVictory(TicTacToeBoard, currentPlayer.GetPlayer()); // Checks to see if the player is a winner
                Console.Clear(); // Clears console

                gameVisualizer.PrintTicTacToeBoard(TicTacToeBoard); // Prints out the board
                Console.WriteLine(); // Blank Line
                Console.WriteLine("It's player 2's Turn!");
                player2.Play(TicTacToeBoard); // Player 2's Turn
                Winner = gameEngine.CheckForVictory(TicTacToeBoard, currentPlayer.GetPlayer()); // Checks to see if the player is a winner
                Console.Clear(); // Clears console

                currentPlayer = currentPlayer.Equals(player1) ? player2 : player1; // Switches players
            }

            gameVisualizer.PrintTicTacToeBoard(TicTacToeBoard); // Prints out the board
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("The winner is {0}!", Winner); // Outputs the winner
            Console.WriteLine();
            Console.WriteLine("Press ENTER to quit");
            Console.ReadLine();
        }
    }
}
