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
        private static int voff=4,hoff=2,sw=10,sh=5;

        public static void Render(TicTacToeGame tictactoe, int i){
            int j=i/3,k=i%3;
            _Win=NCurses.NewWindow(sh, sw, voff+(j*sh-1), hoff+(k*sw-1));
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
        public static void PlayMouse(TicTacToeGame tictactoe, MouseEvent me)
        {
            for(int i=0;i<9;i++){
                int j=i/3,k=i%3;
                if(voff+j*sh<me.y && voff+j*sh+sh>me.y && hoff+k*sw<me.x && hoff+k*sw+sw>me.x)
                    tictactoe.gamePlay(i);
            }
        }

        public static void BoxText(string text)
        {
            int y,x;
            NCurses.GetMaxYX(_Win,out y,out x);
            y/=2;x/=2;
            x-=text.Length/2;
            NCurses.MoveWindowAddString(_Win,y,x,text);
            NCurses.WindowRefresh(_Win);
        }
    }
}