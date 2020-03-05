using System;

namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Subject' abstract class

  /// </summary>

  public class DNCInputMethod : AbstractInputMethod
  {
      protected TicTacToeGame _subjectState;
 
    // Gets or sets subject state

    public TicTacToeGame SubjectState
    {
      get { return _subjectState; }
      set { _subjectState = value; }
    }
    public DNCInputMethod(TicTacToeGame tictactoe){
        this.SubjectState=tictactoe;
    }
  }
 
 }