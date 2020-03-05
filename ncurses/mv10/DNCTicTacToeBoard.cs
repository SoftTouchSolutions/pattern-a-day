using System;
using Mindmagma.Curses;

namespace tictactoeweb.Shared.DesignPatterns{

    public class DNCTicTacToeBoard
    {
        private IntPtr _Win;
        private TicTacToeGame tictactoe=new TicTacToeGame();
        private DNCTextInputMethod textListener;
        private static IntPtr _screen;

        public DNCTicTacToeBoard(){
            _screen = NCurses.InitScreen();
            textListener=new DNCTextInputMethod(tictactoe);
            textListener.Attach(new DNCTextInputAction(this,textListener,"TicTacToeAction"));
        }

        public void Render(){
            NCurses.MoveAddString(2, 0, textListener.SubjectState.winner);
            for(int i=0;i<9;i++){
                DNCTicTacToeBoardSpace.Render(i);
            }
        }
        public void BoxText(string text){
            int y,x;
            // NCurses.ClearWindow(_Win);
            NCurses.GetMaxYX(_Win,out y,out x);
            y/=2;x/=2;
            x-=text.Length/2;
            NCurses.MoveWindowAddString(_Win,y,x,text);
            NCurses.WindowRefresh(_Win);
        }

        public void Play(){
            NCurses.NoDelay(_screen, true);
            NCurses.NoEcho();

            NCurses.MoveAddString(0, 0, "Click a button or use QWE-ASD-ZXC keys.");

            // some terminals require this to differentiate mouse "keys" from random keyboard input
            NCurses.Keypad(_screen, true);

            this.Render();

            // not reporting mouse movement?
            // https://stackoverflow.com/questions/52047158/report-mouse-position-for-ncurses-on-windows/52053196
            // https://stackoverflow.com/questions/7462850/mouse-movement-events-in-ncurses

            var eventsToReport =
                CursesMouseEvent.BUTTON1_CLICKED |
                CursesMouseEvent.BUTTON2_CLICKED |
                CursesMouseEvent.REPORT_MOUSE_POSITION;

            var availableMouseEvents = NCurses.MouseMask(eventsToReport, out uint oldMask);
            //int i=2;
            bool exit = false;
            bool update = true;
            while(!exit)
            {
                switch(NCurses.GetChar())
                {
                    case CursesKey.MOUSE:
                        try
                        {
                            NCurses.GetMouse(out MouseEvent mouse);
                            NCurses.MoveAddString(3, 0, $"{mouse.x.ToString("000")}  {mouse.y.ToString("000")}");
                            update = true;
                        }
                        catch (DotnetCursesException)
                        {
                            // no events in the queue
                        }
                        break;

                    case -1:
                        // no input received
                        break;

                    default:
                        //textListener.Notify();
                        exit =true;// i--==0?true:false;
                        break;
                }

                if (update)
                {
                    NCurses.Move(NCurses.Lines - 1, NCurses.Columns - 1);
                    NCurses.Refresh();
                    update = false;
                }
            }

        }
    }
}