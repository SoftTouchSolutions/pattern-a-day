
using System;
using System.Threading.Tasks;
using Microsoft.JSInterop;
using Microsoft.AspNetCore.Blazor.Components;

namespace tictactoeweb.Shared.DesignPatterns
{
    public class TicTacToeGame
    {
        private final _random = new Random();
        public int[][] winstates = new int {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8},
            {0, 3, 6},
            {1, 4, 7},
            {2, 5, 8},
            {0, 4, 8},
            {2, 4, 6},
        };
        public String[] gameState = {'-', '-', '-', '-', '-', '-', '-', '-', '-'};
        private bool XTurnToPlay = true;
        public String winner="";
        public int windex=-1;

        public static void gameLoop() {
            var tictactoe = new TicTacToeGame();
            tictactoe.getNextState();
            while (!tictactoe.isBoardFilled()) {
            tictactoe.getNextState();
            if (tictactoe.isWinState())break;
            }
            if(tictactoe.isWinState())
            print((tictactoe.XTurnToPlay ? 'O' : 'X') + ' wins');
            else 
            print('game was a draw');
            tictactoe.printState();
        }
        public void reset(){
            this.gameState = ['-', '-', '-', '-', '-', '-', '-', '-', '-'];
            this.XTurnToPlay = true;
            this.winner="";
            this.windex=-1;
        }
        public void gamePlay(){
            if(this.isWinState()||this.isBoardFilled())this.reset();
            this.getNextState();
        }
        public void getNextState() {
            int v = _next(0, 9);
            while (this.gameState[v] != '-') {
            v = _next(0, 9);
            }
            this.gameState[v] = this.XTurnToPlay ? 'X' : 'O';
            this.XTurnToPlay = !this.XTurnToPlay;
            this.winner=this.isWinState()?(this.XTurnToPlay?'O':'X')+' wins':(this.isBoardFilled()?'game was a draw':'');
            //print('this.windex=${this.windex}');
            // this.testWinState();
        }

        public bool isWinState() {
            var winstate=false;
            for(var i=0;i<this.winstates.length;i++){
            if(gameState[winstates[i][0]]!='-' && gameState[winstates[i][0]]==gameState[winstates[i][1]] && gameState[winstates[i][1]]==gameState[winstates[i][2]]){
                this.windex=i;
                winstate=true;
                break;
            }
            }
            return winstate;
        }

        public bool isBoardFilled() {
            return !this.gameState.contains('-');
        }
        
        public void printState(){
            var sb=StringBuffer();
            for(var i=0;i<3;i++){
            for(var j=0;j<3;j++)
                sb.write(this.gameState[i*3+j]);
            print(sb);
            sb.clear();
            }
        }

        /**
        * Generates a positive random integer uniformly distributed on the      range
        * from [min], inclusive, to [max], exclusive.
        */
        private int _next(int min, int max) => min + _random.nextInt(max - min);
        public void testWinState(){
            for(var i=0;i<this.winstates.length;i++){
            print("${this.winstates[i][0]}=${this.gameState[this.winstates[i][0]]}:${this.gameState[this.winstates[i][0]]!='-'}");
            print("${this.winstates[i][1]}=${this.gameState[this.winstates[i][1]]}:${this.gameState[this.winstates[i][1]]!='-'}");
            print("${this.winstates[i][2]}=${this.gameState[this.winstates[i][2]]}:${this.gameState[this.winstates[i][2]]!='-'}");
            }
        }
    }
}