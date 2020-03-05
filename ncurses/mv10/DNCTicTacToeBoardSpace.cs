using System;
using Mindmagma.Curses;

namespace tictactoeweb.Shared.DesignPatterns{

    public class DNCTicTacToeBoardSpace
    {
        private static IntPtr _Win;
        private static string[] ky={"Q","W","E","A","S","D","Z","X","C"};
        public static void Render(int i){
                int j=i/3;
                int k=i%3;
                _Win=NCurses.NewWindow(5, 10, 4+(j*4), 2+(k*9));
                NCurses.Refresh();
                NCurses.Box(_Win,(char)0,(char)0);
                NCurses.WindowRefresh(_Win);
                BoxText(ky[i]);
        }
        public static void BoxText(string text){
                int y,x;
                NCurses.GetMaxYX(_Win,out y,out x);
                y/=2;x/=2;
                x-=text.Length/2;
                NCurses.MoveWindowAddString(_Win,y,x,text);
                NCurses.WindowRefresh(_Win);
        }
    }
}