 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Subject' abstract class

  /// </summary>

  public class DNCTextInputMethod : AbstractTextInputMethod
  {
      
      public DNCTextInputMethod(TicTacToeGame tictactoe){
          this.SubjectState=tictactoe;
      }
  }
 
 }