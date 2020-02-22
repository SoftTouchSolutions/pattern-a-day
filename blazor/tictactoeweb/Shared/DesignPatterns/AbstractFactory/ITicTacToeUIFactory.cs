
 
 namespace tictactoeweb.Shared.DesignPatterns.AbstractFactory{

  /// <summary>

  /// The 'AbstractFactory' abstract class

  /// </summary>

  abstract class ITicTacToeUIFactory
  {
    public abstract ITicTacToeBoard getBoard(TicTacToeGame tictactoe,bool glow);
  }

 }
