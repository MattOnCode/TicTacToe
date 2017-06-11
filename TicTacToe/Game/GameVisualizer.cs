using System;

namespace TicTacToe {
    class GameVisualizer {

        /// <summary>
        /// Function to print out the current TicTacToe board
        /// </summary>
        /// <param name="ticTacToeBoard">The TicTacToe Board</param>
        public void PrintTicTacToeBoard(string[,] ticTacToeBoard) {
            Console.WriteLine("---Board---");
            for (int i = 0; i < ticTacToeBoard.GetLength(0); i++) {
                for (int j = 0; j < ticTacToeBoard.GetLength(0); j++) {
                    Console.Write(ticTacToeBoard[i, j]); // Prints out each tile
                }
                Console.WriteLine(); // Starts new line
            }
        }

        /// <summary>
        /// Function to fill a newly created TicTacToe Board with empty tiles
        /// </summary>
        /// <param name="ticTacToeBoard">The TicTacToe Board</param>
        public void InitalizeBoard(string[,] ticTacToeBoard) {
            for (int i = 0; i < ticTacToeBoard.GetLength(0); i++) {
                for (int j = 0; j < ticTacToeBoard.GetLength(0); j++) {
                    ticTacToeBoard[i, j] = " "; // Fills tile with an empty slot
                }
            }
        }

    }
}
