using System;
using System.Collections.Generic;

namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Observer' abstract class

  /// </summary>

  public abstract class AbstractTextInputAction : AbstractInputAction

  {
    protected string _name;
    protected TicTacToeGame _observerState;
    protected AbstractTextInputMethod _subject;
 
    // Constructor

    public AbstractTextInputAction(AbstractTextInputMethod subject, string name)
    {
      this._subject = subject;
      this._name = name;
    }
 
    public override void Update()
    {
      _observerState = _subject.SubjectState;
      Console.WriteLine("Observer {0}'s new state is {1}",
        this, _observerState);
    }
 
    // Gets or sets subject

    public AbstractTextInputMethod Subject
    {
      get { return _subject; }
      set { _subject = value; }
    }
  }

 }