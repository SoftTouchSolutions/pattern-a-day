using System;

 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Observer' abstract class

  /// </summary>

  public class DNCTextInputAction : AbstractTextInputAction 
  {
    private DNCTicTacToeBoard _tictactoe;
    public DNCTextInputAction(DNCTicTacToeBoard tictactoe, AbstractTextInputMethod subject, string name)
      :base(subject,name)
    {
      this._tictactoe=tictactoe;
    }
    public override void Update()
    {
      _observerState = _subject.SubjectState;
      // Console.WriteLine($"Observer {_name}'s new state is {_observerState.ToString()}");
      _tictactoe.BoxText($"hi ");//new state is {_observerState.ToString()}");
    }
  }

 }