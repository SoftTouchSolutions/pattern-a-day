
using System;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace tictactoeweb.Shared.DesignPatterns
{
    public class TicTacToeGame : ITicTacToeStrategy
    {
        private Random _random = new Random();
        public int[][] winstates = new int[][] {
            new int[]{0, 1, 2},
            new int[]{3, 4, 5},
            new int[]{6, 7, 8},
            new int[]{0, 3, 6},
            new int[]{1, 4, 7},
            new int[]{2, 5, 8},
            new int[]{0, 4, 8},
            new int[]{2, 4, 6},
        };
        public String[] gameState = {"-","-","-","-","-","-","-","-","-"};
        private bool XTurnToPlay = true;
        public String winner="TicTacToe Demo";
        public int windex=-1;

        public static void gameLoop() {
            var tictactoe = new TicTacToeGame();
            tictactoe.getNextState();
            while (!tictactoe.isBoardFilled()) {
            tictactoe.getNextState();
            if (tictactoe.isWinState())break;
            }
            if(tictactoe.isWinState())
            	Console.WriteLine((tictactoe.XTurnToPlay ? "O" : "X") + " wins");
            else 
            	Console.WriteLine("game was a draw");
            tictactoe.printState();
        }
        public void reset(){
            this.gameState = new String[] {"-","-","-","-","-","-","-","-","-"};
            this.XTurnToPlay = true;
            this.winner="TicTacToe Demo";
            this.windex=-1;
        }
        public void gamePlay(int idx=-1){
            if(this.isWinState()||this.isBoardFilled())this.reset();
            if(idx!=-1){
                this.XTurnToPlay=false;
                if(this.gameState[idx].Equals("-")){
                    this.gameState[idx]="X";
                }else return;
                if(this.isWinState()){
                    this.winner="X Wins";
                    return;
                }else if(this.isBoardFilled()){
                    this.winner="game was a draw";
                    return;
                }
            }
            this.getNextState();
        }
        public void getNextState() {
            int v = _next(0, 9);
            while (this.gameState[v] != "-") {
            v = _next(0, 9);
            }
            this.gameState[v] = this.XTurnToPlay ? "X" : "O";
            this.XTurnToPlay = !this.XTurnToPlay;
            this.winner=this.isWinState()?(this.XTurnToPlay?"O":"X")+" wins":(this.isBoardFilled()?"game was a draw":this.winner);
            //print('this.windex=${this.windex}');
            // this.testWinState();
        }

        public bool isWinState() {
            var winstate=false;
            for(var i=0;i<this.winstates.Length;i++){
            if(gameState[winstates[i][0]]!="-" && gameState[winstates[i][0]]==gameState[winstates[i][1]] && gameState[winstates[i][1]]==gameState[winstates[i][2]]){
                this.windex=i;
                winstate=true;
                break;
            }
            }
            return winstate;
        }

        public bool isBoardFilled() {
            return !this.gameState.ToList().Contains("-");
        }
        
        public void printState(){
            var sb=new StringBuilder();
            for(var i=0;i<3;i++){
				for(var j=0;j<3;j++)
					sb.Append(this.gameState[i*3+j]);
				Console.WriteLine(sb.ToString());
            sb.Clear();
            }
        }

        /**
        * Generates a positive random integer uniformly distributed on the      range
        * from [min], inclusive, to [max], exclusive.
        */
        private int _next(int min, int max) => min + _random.Next(max - min);
		
        public void testWinState(){
            for(var i=0;i<this.winstates.Length;i++){
				//Console.WriteLine(@"${this.winstates[i][0]}=${this.gameState[this.winstates[i][0]]}:${this.gameState[this.winstates[i][0]]!="-"}");
				//Console.WriteLine(@"${this.winstates[i][1]}=${this.gameState[this.winstates[i][1]]}:${this.gameState[this.winstates[i][1]]!="-"}");
				//Console.WriteLine(@"${this.winstates[i][2]}=${this.gameState[this.winstates[i][2]]}:${this.gameState[this.winstates[i][2]]!="-"}");
            }
        }
    }
}