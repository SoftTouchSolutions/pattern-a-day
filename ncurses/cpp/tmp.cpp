#include <ncurses.h>
using namespace std;

int main(int argc, char **argv){
    // initialise
    // setup memory and clear screen
    initscr();

    move(10,10);

    //print a string to a window
    printw("Hello world!");

    // refresh screen to match memory
    refresh();

    // move(y,x) move to specific location
    int c= getch();
    printw("%d",c);
    //getch as we know it
    getch();

    //deallocate memory and ends ncurses
    endwin();

    return 0;
}