
 
 namespace tictactoeweb.Shared.DesignPatterns.AbstractFactory{

  /// <summary>

  /// The 'AbstractFactory' abstract class

  /// </summary>

  abstract class ITicTacToeUIFactory
  {
    public abstract AbstractProductA CreateProductA();
    public abstract AbstractProductB CreateProductB();
  }

 }
