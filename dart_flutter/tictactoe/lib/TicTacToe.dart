import 'dart:math';

class TicTacToe {

  final _random = new Random();
  final List winstates = const [
    [0, 1, 2],
    [3, 4, 5],
    [6, 7, 8],
    [0, 3, 6],
    [1, 4, 7],
    [2, 5, 8],
    [0, 4, 8],
    [2, 4, 6],
  ];
  List gameState = ['-', '-', '-', '-', '-', '-', '-', '-', '-'];
  bool XTurnToPlay = true;
  String winner="";

  static void gameLoop() {
    var tictactoe = new TicTacToe();
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
  void reset(){
    this.gameState = ['-', '-', '-', '-', '-', '-', '-', '-', '-'];
    this.XTurnToPlay = true;
    this.winner="";
  }
  void gamePlay(){
    if(this.isWinState()||this.isBoardFilled())this.reset();
      this.getNextState();
  }
  void getNextState() {
    int v = _next(0, 9);
    while (this.gameState[v] != '-') {
      v = _next(0, 9);
    }
    this.gameState[v] = this.XTurnToPlay ? 'X' : 'O';
    this.XTurnToPlay = !this.XTurnToPlay;
    this.winner=this.isWinState()?(this.XTurnToPlay?'O':'X')+' wins':(this.isBoardFilled()?'game was a draw':'');
  }

  bool isWinState() {
    return this
        .winstates
        .fold(false, (t, e) 
              => t || (e.fold(true, (x, y) 
                              => x && (this.gameState[e[0]] == this.gameState[y]) && (this.gameState[e[0]]!='-'))));
  }

  bool isBoardFilled() {
    return !this.gameState.contains('-');
  }
  
  void printState(){
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
  int _next(int min, int max) => min + _random.nextInt(max - min);
  void testWinState(){
    for(var i=0;i<this.winstates.length;i++){
      print("${this.winstates[i][0]}=${this.gameState[this.winstates[i][0]]}:${this.gameState[this.winstates[i][0]]!='-'}");
      print("${this.winstates[i][1]}=${this.gameState[this.winstates[i][1]]}:${this.gameState[this.winstates[i][1]]!='-'}");
      print("${this.winstates[i][2]}=${this.gameState[this.winstates[i][2]]}:${this.gameState[this.winstates[i][2]]!='-'}");
    }
  }
}

void main() {

//   var ttt=new TicTacToe();
//   ttt.gameState = ['O', '-', 'X', 'X', 'O', 'X', '-', 'X', 'O'];
//   ttt.printState();
//   print(ttt.isBoardFilled());
//   ttt.getNextState();
//   ttt.printState();
//   print(ttt.isBoardFilled());
//   ttt.getNextState();
//   ttt.printState();
//   print(ttt.isBoardFilled());
 TicTacToe.gameLoop();
}
