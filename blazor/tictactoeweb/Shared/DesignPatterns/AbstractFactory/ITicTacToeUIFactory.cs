
 
 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'AbstractFactory' abstract class

  /// </summary>

  public abstract class ITicTacToeUIFactory
  {
    public abstract ITicTacToeBoard getBoard(TicTacToeGame tictactoe,bool glow);
  }

 }