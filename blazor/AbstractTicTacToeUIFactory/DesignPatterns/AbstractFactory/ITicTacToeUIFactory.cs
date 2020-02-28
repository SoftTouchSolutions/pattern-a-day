
 
 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'AbstractFactory' abstract class

  /// </summary>

  public interface ITicTacToeUIFactory
  {
    ITicTacToeBoard getBoard(TicTacToeGame tictactoe,bool glow);
  }

 }
