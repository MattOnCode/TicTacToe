namespace TicTacToe.Game
{
    class GameEngine 
    {

        /// <summary>
        /// Checks whether a player has won or not
        /// </summary>
        /// <param name="ticTacToeBoard">The game board</param>
        /// <param name="currentPlayer">The player who's turn it is</param>
        /// <returns>Whether or not the player has won</returns>
        public string CheckForVictory(string[,] ticTacToeBoard, string currentPlayer) 
        {
            var horizontalVictory = 0;
            var verticalVictory = 0;
            var diagonalVictory = 0;
            var tilesFilled = 0;

            // Checks for horizontal victories by cyling through the board
            for (var i = 0; i < ticTacToeBoard.GetLength(0); i++) 
            {
                if (horizontalVictory == 3)
                    break;
                else
                    horizontalVictory = 0;
                
                for (var j = 0; j < ticTacToeBoard.GetLength(0); j++) 
                {
                    if (ticTacToeBoard[i, j].Equals(currentPlayer))
                        horizontalVictory++;
                }
            }

            // Checks for vertical victories
            for (var i = 0; i < ticTacToeBoard.GetLength(0); i++) 
            {
                if (verticalVictory == 3)
                    break;
                else
                    verticalVictory = 0;
                
                for (var j = 0; j < ticTacToeBoard.GetLength(0); j++) 
                {
                    if (ticTacToeBoard[j, i].Equals(currentPlayer))
                        verticalVictory++;
                }
            }

            // Checks for diagonal victories
            for(var i = 0; i < ticTacToeBoard.GetLength(0); i++) 
            {
                if (ticTacToeBoard[i, i].Equals(currentPlayer))
                    diagonalVictory++;
            }
            if(diagonalVictory != 3) 
            {
                diagonalVictory = 0;
                for(var i = 0; i < ticTacToeBoard.GetLength(0); i++) 
                {
                    if (ticTacToeBoard[(ticTacToeBoard.GetLength(0) - 1) - i, (ticTacToeBoard.GetLength(0) - 1) - i].Equals(currentPlayer))
                        diagonalVictory++;
                }
            }

            // Checks to see if there's no winner
            for (var i = 0; i < ticTacToeBoard.GetLength(0); i++) 
            {
                for (var j = 0; j < ticTacToeBoard.GetLength(0); j++) 
                {
                    if(!ticTacToeBoard[i, j].Equals(" ")) 
                        ++tilesFilled;
                }
            }

            if(tilesFilled <= 9) 
                return horizontalVictory == 3 || verticalVictory == 3 || diagonalVictory == 3 ? currentPlayer : string.Empty;
            else 
                return "Nobody";
        }
    }
}
