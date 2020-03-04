using System;
using Mindmagma.Curses;

namespace tictactoeweb.Shared.DesignPatterns{

    public class DNCTicTacToeBoard
    
    {
        public static void Render(){
                var win=NCurses.NewWindow(4, 10, 5, 20);
                NCurses.Refresh();
                NCurses.Box(win,(char)0,(char)0);
                NCurses.WindowRefresh(win);
                //NCurses.GetChar();
        }
    }
}