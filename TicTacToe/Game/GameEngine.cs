namespace TicTacToe {
    class GameEngine {

        /// <summary>
        /// Checks whether a player has won or not
        /// </summary>
        /// <param name="ticTacToeBoard">The game board</param>
        /// <param name="currentPlayer">The player who's turn it is</param>
        /// <returns>Whether or not the player has won</returns>
        public string CheckForVictory(string[,] ticTacToeBoard, string currentPlayer) {
            var HorizontalVictory = 0;
            var VerticalVictory = 0;
            var DiagonalVictory = 0;

            // Checks for horizontal victories by cyling through the board
            for (int i = 0; i < ticTacToeBoard.GetLength(0); i++) {
                if (HorizontalVictory == 3)
                    break;
                else
                    HorizontalVictory = 0;
                for (int j = 0; j < ticTacToeBoard.GetLength(0); j++) {
                    if (ticTacToeBoard[i, j].Equals(currentPlayer))
                        HorizontalVictory++;
                }
            }

            // Checks for vertical victories
            for (int i = 0; i < ticTacToeBoard.GetLength(0); i++) {
                if (VerticalVictory == 3)
                    break;
                else
                    VerticalVictory = 0;
                for (int j = 0; j < ticTacToeBoard.GetLength(0); j++) {
                    if (ticTacToeBoard[j, i].Equals(currentPlayer))
                        VerticalVictory++;
                }
            }

            // Checks for diagonal victories
            for(int i = 0; i < ticTacToeBoard.GetLength(0); i++) {
                if (ticTacToeBoard[i, i].Equals(currentPlayer))
                    DiagonalVictory++;
            }
            if(DiagonalVictory != 3) {
                DiagonalVictory = 0;
                for(int i = 0; i < ticTacToeBoard.GetLength(0); i++) {
                    if (ticTacToeBoard[(ticTacToeBoard.GetLength(0) - 1) - i, (ticTacToeBoard.GetLength(0) - 1) - i].Equals(currentPlayer))
                        DiagonalVictory++;
                }
            }

            // If the player has won, return the player. If not, return 'false' (as an empty string)
            return HorizontalVictory == 3 || VerticalVictory == 3 || DiagonalVictory == 3 ? currentPlayer : string.Empty;
        }
    }
}
