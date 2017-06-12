using System;

namespace TicTacToe {
    class GameManager {

        // Creates local class variables for other classes
        private readonly GameVisualizer _gameVisualizer;
        private readonly GameEngine _gameEngine;

        /// <summary>
        /// Constructor for GameManager
        /// </summary>
        /// <param name="argGameVisualizer">Passes in Game Visualizer class</param>
        /// <param name="argGameEngine">Passes in Game Engine class</param>
        public GameManager(GameVisualizer argGameVisualizer, GameEngine argGameEngine) {
            _gameVisualizer = argGameVisualizer;
            _gameEngine = argGameEngine;
        }

        /// <summary>
        /// Function to start a new game of Tic Tac Toe
        /// </summary>
        /// <param name="TicTacToeBoard">The TicTacToe board</param>
        /// <param name="player1">Player 1</param>
        /// <param name="player2">Player 2</param>
        public void PlayGame(string[,] TicTacToeBoard, IPlayer player1, IPlayer player2) {
            _gameVisualizer.InitalizeBoard(TicTacToeBoard); // Creates a new board

            // Loops until the player chooses either X or O
            Console.WriteLine("Player1, Do you wish to be X or O?");
            while (true) {
                var player1Name = Console.ReadLine().ToUpper();
                if (player1Name.ToUpper().Equals("X") || player1Name.ToUpper().Equals("O")) {
                    player1.SetPlayer(player1Name);
                    break;
                }

            }
            player2.SetPlayer(player1.GetPlayer().ToUpper().Equals("X") ? "O" : "X"); // Automatically set the other player to the opposite

            var Winner = string.Empty; // Resets winner
            var currentPlayer = player1; // Set's player 1to play first

            // The game will continue to play until there's a winner
            while (Winner.Equals(string.Empty)) {
                player1.Play(TicTacToeBoard);
                player2.Play(TicTacToeBoard);
                _gameVisualizer.PrintTicTacToeBoard(TicTacToeBoard);
                Winner = _gameEngine.CheckForVictory(TicTacToeBoard, currentPlayer.GetPlayer());
                currentPlayer = currentPlayer.Equals(player1) ? player2 : player1;
            }

            Console.WriteLine("The winner is {0}", Winner); // Outputs the winner
        }
    }
}
