
using Microsoft.AspNetCore.Components;

 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'AbstractFactory' abstract class

  /// </summary>

  public abstract class ITicTacToeBoard: ComponentBase
  {
    public abstract ITicTacToeBoardSpace getBoardSpace();
    public abstract ITicTacToeBoardLine buildLines();
  }

 }
