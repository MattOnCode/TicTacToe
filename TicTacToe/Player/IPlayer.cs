namespace TicTacToe.Player
{
    interface IPlayer 
    {

        string GetPlayer();
        void SetPlayer(string player);
        void Play(string[,] ticTacToeBoard);

    }
}
