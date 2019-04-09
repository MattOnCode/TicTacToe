namespace TicTacToe.Player
{
    class AIPlayer : IPlayer 
    {

        /// <summary>
        /// A very simple AI which will simply fill
        /// the first available tile.
        /// TO-DO: This needs to be improved.
        /// </summary>

        private string _player;

        // Gets the AI Player
        public string GetPlayer() 
        {
            return _player;
        }

        // Sets the player to an AI player
        public void SetPlayer(string player) 
        {
            this._player = player;
        }

        /// <summary>
        /// This Function makes the AI Player "Play" their turn.
        /// It does so by filling the first available slot.
        /// </summary>
        /// <param name="ticTacToeBoard">The TicTacToe Game Board</param>
        public void Play(string[,] ticTacToeBoard) 
        {
            for(var i=0; i < ticTacToeBoard.GetLength(0); i++) 
            {
                for (var j = 0; j < ticTacToeBoard.GetLength(0); j++) 
                {
                    if(ticTacToeBoard[i,j].Equals(" ")) 
                    {
                        ticTacToeBoard[i, j] = _player;
                        return;
                    }
                }
            }
        }
    }
}
