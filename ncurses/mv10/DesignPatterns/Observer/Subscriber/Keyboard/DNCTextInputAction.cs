using System;

 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Observer' abstract class

  /// </summary>

  public class DNCTextInputAction : AbstractTextInputAction

  {
    public DNCTextInputAction(AbstractTextInputMethod subject, string name)
      :base(subject,name)
    {
    }
    public override void Update()
    {
      _observerState = _subject.SubjectState;
      DNCTicTacToeBoard.BoxText($"Observer {_name}'s new state is {_observerState}");
    }
  }

 }