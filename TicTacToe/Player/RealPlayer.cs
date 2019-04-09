using System;

namespace TicTacToe.Player
{
    class RealPlayer : IPlayer 
    {

        private string _player;

        // Gets the real player
        public string GetPlayer() 
        {
            return _player;
        }

        // Sets the player to a real player
        public void SetPlayer(string player) 
        {
            this._player = player;
        }

        /// <summary>
        /// Function to allow the player to play their turn. It will
        /// ask the player which position on the board they wish to fill
        /// then it'll fill it.
        /// </summary>
        /// <param name="ticTacToeBoard">The TicTacToe Board</param>
        public void Play(string[,] ticTacToeBoard)
        {
        
            int positionX;
            int positionY;

            // Prompts for the users X position
            Console.WriteLine("Enter position X for {0}", _player);
            var userXInput = Console.ReadLine();
            while(true) 
            { 
                if (int.TryParse(userXInput, out positionX) == true) 
                {
                    if (positionX <= 2)
                        break;
                }
                Console.WriteLine(); // Blank Line
                Console.WriteLine("That is not a valid input!  Your input must be (0, 1, 2)");
                Console.WriteLine("Enter position X for {0}", _player);
                userXInput = Console.ReadLine();
            }

            // Prompts for the users Y position
            Console.WriteLine("Enter position Y for {0}", _player);
            var userYInput = Console.ReadLine();
            while (true) 
            {
                if (int.TryParse(userYInput, out positionY) == true) 
                {
                    if (positionY <= 2)
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("That is not a valid input! Your input must be (0, 1, 2)");
                Console.WriteLine("Enter position Y for {0}", _player);
                userYInput = Console.ReadLine();
            }

            // Updates the board with the users play
            if (ticTacToeBoard[positionX, positionY].Equals(" ")) 
                ticTacToeBoard[positionX, positionY] = _player;
        }
    }
}
