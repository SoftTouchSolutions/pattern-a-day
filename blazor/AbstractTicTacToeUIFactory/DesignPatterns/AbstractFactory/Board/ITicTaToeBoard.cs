

 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'AbstractFactory' abstract class

  /// </summary>

  public interface ITicTacToeBoard
  {
    ITicTacToeBoardSpace getBoardSpace();
    ITicTacToeBoardLine buildLines();
  }

 }
