 using System;

namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Subject' abstract class

  /// </summary>

  public class DNCMouseInputMethod : AbstractMouseInputMethod
  {
      public DNCMouseInputMethod(TicTacToeGame tictactoe){
          this.SubjectState=tictactoe;
      }
  }
 
 }