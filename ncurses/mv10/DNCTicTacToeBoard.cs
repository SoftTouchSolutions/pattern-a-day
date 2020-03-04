using System;
using Mindmagma.Curses;

namespace tictactoeweb.Shared.DesignPatterns{

    public class DNCTicTacToeBoard
    {
        private static IntPtr _Win;

        public static void Render(){
                _Win=NCurses.NewWindow(4, 10, 5, 20);
                NCurses.Refresh();
                NCurses.Box(_Win,(char)0,(char)0);
                NCurses.WindowRefresh(_Win);
                //NCurses.GetChar();
        }
        public static void BoxText(string text){
                //NCurses.Refresh();
                mvprintw(win,y,x,char*);
                NCurses.WindowRefresh(_Win);
                //NCurses.GetChar();
        }
    }
}