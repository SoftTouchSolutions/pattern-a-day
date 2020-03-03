using System;
using System.Collections.Generic;

namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Observer' abstract class

  /// </summary>

  public abstract class AbstractMouseInputAction : AbstractInputAction

  {
    protected string _name;
    protected string _observerState;
    protected AbstractMouseInputMethod _subject;
 
    // Constructor

    public AbstractMouseInputAction(AbstractMouseInputMethod subject, string name)
    {
      this._subject = subject;
      this._name = name;
    }
 
    public override void Update()
    {
      _observerState = _subject.SubjectState;
      Console.WriteLine("Observer {0}'s new state is {1}",
        _name, _observerState);
    }
 
    // Gets or sets subject

    public AbstractMouseInputMethod Subject
    {
      get { return _subject; }
      set { _subject = value; }
    }
  }

 }