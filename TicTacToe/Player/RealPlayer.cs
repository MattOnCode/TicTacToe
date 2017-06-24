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
        
            int positionX; // The X position for the players play
            int positionY; // The Y position for the players play

            // Prompts for the users X position
            Console.WriteLine("Enter position X for {0}", player);
            String userXInput = Console.ReadLine();
            while(true) { // Strict validation for the users input
                if (Int32.TryParse(userXInput, out positionX) == true) {
                    if (positionX <= 2) {
                        break;
                    }
                }
                Console.WriteLine(); // Blank Line
                Console.WriteLine("That is not a valid input!  Your input must be (0, 1, 2)");
                Console.WriteLine("Enter position X for {0}", player);
                userXInput = Console.ReadLine();
            }

            // Prompts for the users Y position
            Console.WriteLine("Enter position Y for {0}", player);
            String userYInput = Console.ReadLine();
            while (true) { // Strict validation for the users input
                if (Int32.TryParse(userYInput, out positionY) == true) {
                    if (positionY <= 2) {
                        break;
                    }
                }
                Console.WriteLine(); // Blank Line
                Console.WriteLine("That is not a valid input! Your input must be (0, 1, 2)");
                Console.WriteLine("Enter position Y for {0}", player);
                userYInput = Console.ReadLine();
            }

            // Updates the board with the users play
            if (TicTacToeBoard[positionX, positionY].Equals(" ")) {
                TicTacToeBoard[positionX, positionY] = player;
            }
        }
    }
}
