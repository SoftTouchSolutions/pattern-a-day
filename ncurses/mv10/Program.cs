using System;
using Mindmagma.Curses;

namespace tictactoeweb.Shared.DesignPatterns{

    class Program
    {
        private static readonly Random rng = new Random();
        private static DNCTicTacToeBoard tictactoe=new DNCTicTacToeBoard();

        static void Main(string[] args)
        {
            try
            {
                tictactoe.Play();
            }
            finally
            {
                NCurses.EndWin();
            }
        }

    }
}