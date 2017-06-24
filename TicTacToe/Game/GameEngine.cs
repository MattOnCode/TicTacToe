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
            var tilesFilled = 0;

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

            // Checks to see if there's no winner
            for (int i = 0; i < ticTacToeBoard.GetLength(0); i++) {
                for (int j = 0; j < ticTacToeBoard.GetLength(0); j++) {
                    if(!ticTacToeBoard[i, j].Equals(" ")) {
                        ++tilesFilled;
                    }
                }
            }

            if(tilesFilled <= 9) { // Checks if boards full
                return HorizontalVictory == 3 || VerticalVictory == 3 || DiagonalVictory == 3 ? currentPlayer : string.Empty; // returns player if they've won
            } else {
                return "Nobody"; // Returns nobody if nobody has won
            }
        }
    }
}
