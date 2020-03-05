using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using Mindmagma.Curses;

namespace tictactoeweb.Shared.DesignPatterns{

    public class DNCTicTacToeBoardSpace
    {
        private static IntPtr _Win;
        private static string[] ky={"Q","W","E","A","S","D","Z","X","C"};

        public static void Render(TicTacToeGame tictactoe, int i){
            int j=i/3,k=i%3,voff=4,hoff=2,bw=10,bh=5;
            _Win=NCurses.NewWindow(bh, bw, voff+(j*bh-1), hoff+(k*bw-1));
            NCurses.Refresh();
            NCurses.Box(_Win,(char)0,(char)0);
            NCurses.WindowRefresh(_Win);
            if(!tictactoe.gameStarted()){
                BoxText(ky[i]);
            }else
            if( (tictactoe.windex!=-1 
                && tictactoe.winstates[tictactoe.windex].ToList().Contains(i)) ){
                    NCurses.StartColor();
                    NCurses.InitPair(1,CursesColor.RED,CursesColor.YELLOW);
                    NCurses.AttributeOn(NCurses.ColorPair(1));
                    BoxText(tictactoe.gameState[i]);
                    NCurses.AttributeOff(NCurses.ColorPair(1));
                }
            else
                    BoxText(tictactoe.gameState[i]);
            // if(!tictactoe.gameStarted()){
            //     BoxText(ky[i]);
            // }
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