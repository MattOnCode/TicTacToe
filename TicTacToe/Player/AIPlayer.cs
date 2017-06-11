using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    class AIPlayer : IPlayer {

        /// <summary>
        /// A very simple AI which will simply fill
        /// the first available tile.
        /// TO-DO: This needs to be improved.
        /// </summary>

        private string player;

        // Gets the AI Player
        public string GetPlayer() {
            return player;
        }

        // Sets the player to an AI player
        public void SetPlayer(string player) {
            this.player = player;
        }

        /// <summary>
        /// This Function makes the AI Player "Play" their turn.
        /// It does so by filling the first available slot.
        /// </summary>
        /// <param name="TicTacToeBoard">The TicTacToe Game Board</param>
        public void Play(string[,] TicTacToeBoard) {
            for(int i=0; i < TicTacToeBoard.GetLength(0); i++) {
                for (int j = 0; j < TicTacToeBoard.GetLength(0); j++) {
                    if(TicTacToeBoard[i,j].Equals(" ")) { // If the slot is free
                        TicTacToeBoard[i, j] = player; // Fill the slot with the players type
                        return;
                    }
                }
            }
        }
    }
}
