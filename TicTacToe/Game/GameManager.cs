using System;
using TicTacToe.Player;

namespace TicTacToe.Game
{
    class GameManager 
    {

        // Creates local class variables for other classes
        private readonly GameVisualizer _gameVisualizer;
        private readonly GameEngine _gameEngine;

        /// <summary>
        /// Constructor for GameManager
        /// </summary>
        /// <param name="argGameVisualizer">Passes in Game Visualizer class</param>
        /// <param name="argGameEngine">Passes in Game Engine class</param>
        public GameManager(GameVisualizer argGameVisualizer, GameEngine argGameEngine) 
        {
            _gameVisualizer = argGameVisualizer;
            _gameEngine = argGameEngine;
        }

        /// <summary>
        /// Function to start a new game of Tic Tac Toe
        /// </summary>
        /// <param name="ticTacToeBoard">The TicTacToe board</param>
        /// <param name="player1">Player 1</param>
        /// <param name="player2">Player 2</param>
        public void PlayGame(string[,] ticTacToeBoard, IPlayer player1, IPlayer player2) 
        {
            _gameVisualizer.InitalizeBoard(ticTacToeBoard);

            // Loops until the player chooses either X or O
            Console.WriteLine();
            Console.WriteLine("Player1, Do you wish to be X or O?");
            while (true) 
            {
                var player1Name = Console.ReadLine().ToUpper();
                if (player1Name.ToUpper().Equals("X") || player1Name.ToUpper().Equals("O")) 
                {
                    player1.SetPlayer(player1Name);
                    break;
                }
                Console.WriteLine();
                Console.WriteLine("That is not a valid answer!");
                Console.WriteLine("Player1, Do you wish to be X or O?");
            }
            player2.SetPlayer(player1.GetPlayer().ToUpper().Equals("X") ? "O" : "X"); 
            
            Console.Clear(); 
            var winner = string.Empty;
            var currentPlayer = player1;

            // The game will continue to play until there's a winner
            while (winner.Equals(string.Empty)) 
            {

                _gameVisualizer.PrintTicTacToeBoard(ticTacToeBoard);
                Console.WriteLine();
                Console.WriteLine("It's player 1's Turn!");
                player1.Play(ticTacToeBoard); 
                winner = _gameEngine.CheckForVictory(ticTacToeBoard, currentPlayer.GetPlayer());
                Console.Clear();

                _gameVisualizer.PrintTicTacToeBoard(ticTacToeBoard);
                Console.WriteLine();
                Console.WriteLine("It's player 2's Turn!");
                player2.Play(ticTacToeBoard);
                winner = _gameEngine.CheckForVictory(ticTacToeBoard, currentPlayer.GetPlayer());
                Console.Clear();

                currentPlayer = currentPlayer.Equals(player1) ? player2 : player1;
            }

            _gameVisualizer.PrintTicTacToeBoard(ticTacToeBoard);
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("The winner is {0}!", winner);
            Console.WriteLine();
            Console.WriteLine("Press ENTER to quit");
            Console.ReadLine();
        }
    }
}
