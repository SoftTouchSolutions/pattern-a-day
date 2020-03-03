using System;
using System.Collections.Generic;

 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Subject' abstract class

  /// </summary>

  public abstract class AbstractTextInputMethod

  {
     protected string _subjectState;
 
    // Gets or sets subject state

    public string SubjectState
    {
      get { return _subjectState; }
      set { _subjectState = value; }
    }

  }
 
 }