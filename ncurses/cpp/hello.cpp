#include <ncurses.h>
using namespace std;

int main(int argc, char **argv){
    // initialise
    // setup memory and clear screen
    initscr();

    //print a string to a window
    printw("Hello world!");

    // refresh screen to match memory
    refresh();

    //getch as we know it
    getch();

    //deallocate memory and ends ncurses
    endwin();

    return 0;
}