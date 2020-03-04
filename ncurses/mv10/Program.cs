using System;
using Mindmagma.Curses;

namespace tictactoeweb.Shared.DesignPatterns{

    class Program
    {
        private static IntPtr Screen;
        private static readonly Random rng = new Random();
        private static TicTacToeGame tictactoe=new TicTacToeGame();
        private static DNCTextInputMethod textListener=new DNCTextInputMethod(tictactoe);

        static void Main(string[] args)
        {
            textListener.Attach(new DNCTextInputAction(textListener,"TicTacToeAction"));
            Screen = NCurses.InitScreen();
            try
            {
                Mouse();
            }
            finally
            {
                NCurses.EndWin();
            }
        }

        static void Mouse()
        {
            NCurses.NoDelay(Screen, true);
            NCurses.NoEcho();

            NCurses.MoveAddString(0, 0, "Click a button or press any key to exit.");
            NCurses.MoveAddString(2, 0, "[X]  [Y]");

            DNCTicTacToeBoard.Render();
            // some terminals require this to differentiate mouse "keys" from random keyboard input
            NCurses.Keypad(Screen, true);

            // not reporting mouse movement?
            // https://stackoverflow.com/questions/52047158/report-mouse-position-for-ncurses-on-windows/52053196
            // https://stackoverflow.com/questions/7462850/mouse-movement-events-in-ncurses

            var eventsToReport =
                CursesMouseEvent.BUTTON1_CLICKED |
                CursesMouseEvent.BUTTON2_CLICKED |
                CursesMouseEvent.REPORT_MOUSE_POSITION;

            var availableMouseEvents = NCurses.MouseMask(eventsToReport, out uint oldMask);

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
                        textListener.Notify();
                        exit = true;
                        break;
                }

                if (update)
                {
                    NCurses.Move(NCurses.Lines - 1, NCurses.Columns - 1);
                    NCurses.Refresh();
                    update = false;
                }
            }
            NCurses.GetChar();
        }
    }
}