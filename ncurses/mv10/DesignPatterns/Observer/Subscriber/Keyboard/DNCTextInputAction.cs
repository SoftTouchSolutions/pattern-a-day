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
      _tictactoe.Render();
    }
  }

 }