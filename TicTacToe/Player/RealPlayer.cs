using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe {
    class RealPlayer : IPlayer {

        public string player;

        // Gets the real player
        public string GetPlayer() {
            return player;
        }

        // Sets the player to a real player
        public void SetPlayer(string player) {
            this.player = player;
        }

        /// <summary>
        /// Function to allow the player to play their turn. It will
        /// ask the player which position on the board they wish to fill
        /// then it'll fill it.
        /// </summary>
        /// <param name="TicTacToeBoard">The TicTacToe Board</param>
        public void Play(string[,] TicTacToeBoard) {
            Console.WriteLine("Enter position X for {0}", player);
            int positionX = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter position Y for {0}", player);
            int positionY = Int32.Parse(Console.ReadLine());

            if (TicTacToeBoard[positionX, positionY].Equals(" ")) TicTacToeBoard[positionX, positionY] = player;
        }
    }
}
