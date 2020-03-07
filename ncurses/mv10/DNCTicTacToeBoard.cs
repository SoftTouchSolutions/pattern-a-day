using System;
using Mindmagma.Curses;

namespace tictactoeweb.Shared.DesignPatterns{

    public class DNCTicTacToeBoard
    {
        private TicTacToeGame _tictactoe=new TicTacToeGame();
        private DNCInputMethod _iListener;
        private static IntPtr _screen;

        public DNCTicTacToeBoard(){
            _screen = NCurses.InitScreen();
            _iListener=new DNCInputMethod(_tictactoe);
            _iListener.Attach(new DNCInputAction(this,_iListener,"TicTacToeTextAction"));
            NCurses.NoDelay(_screen, true);
            NCurses.NoEcho();
            // some terminals require this to differentiate mouse "keys" from random keyboard input
            NCurses.Keypad(_screen, true);
        }

        public void Render(){
            NCurses.Clear();
            NCurses.MoveAddString(0, 0, "Click a button or use QWE-ASD-ZXC keys.");
            NCurses.MoveAddString(2, 0, _tictactoe.winner);
            for(int i=0;i<9;i++){
                DNCTicTacToeBoardSpace.Render(_tictactoe,i);
            }
            NCurses.Move(NCurses.Lines - 1, NCurses.Columns - 1);
        }

        public void Play(){

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
                            // NCurses.MoveAddString(3, 0, $"{mouse.x.ToString("000")}  {mouse.y.ToString("000")}");
                            DNCTicTacToeBoardSpace.PlayMouse(_tictactoe,mouse);
                            update = true;
                        }
                        catch (DotnetCursesException)
                        {
                            // no events in the queue
                        }
                        break;

                    case (int)'Q':
                    case (int)'q':
                        _tictactoe.gamePlay(0);
                        _iListener.Notify();
                        break;
                    case (int)'W':
                    case (int)'w':
                        _tictactoe.gamePlay(1);
                        _iListener.Notify();
                        break;
                    case (int)'E':
                    case (int)'e':
                        _tictactoe.gamePlay(2);
                        _iListener.Notify();
                        break;
                    case (int)'A':
                    case (int)'a':
                        _tictactoe.gamePlay(3);
                        _iListener.Notify();
                        break;
                    case (int)'S':
                    case (int)'s':
                        _tictactoe.gamePlay(4);
                        _iListener.Notify();
                        break;
                    case (int)'D':
                    case (int)'d':
                        _tictactoe.gamePlay(5);
                        _iListener.Notify();
                        break;
                    case (int)'Z':
                    case (int)'z':
                        _tictactoe.gamePlay(6);
                        _iListener.Notify();
                        break;
                    case (int)'X':
                    case (int)'x':
                        _tictactoe.gamePlay(7);
                        _iListener.Notify();
                        break;
                    case (int)'C':
                    case (int)'c':
                        _tictactoe.gamePlay(8);
                        _iListener.Notify();
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
                    // NCurses.Move(NCurses.Lines - 1, NCurses.Columns - 1);
                    // NCurses.Refresh();
                    _iListener.Notify();
                    update = false;
                }
            }
        }
    }
}