using System;
using System.Collections.Generic;

 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Subject' abstract class

  /// </summary>

  public abstract class AbstractTextInputMethod

  {
     protected TicTacToeGame _subjectState;
 
    // Gets or sets subject state

    public TicTacToeGame SubjectState
    {
      get { return _subjectState; }
      set { _subjectState = value; }
    }

  }
 
 }