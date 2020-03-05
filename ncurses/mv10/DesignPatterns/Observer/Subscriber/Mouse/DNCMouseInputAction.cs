 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Observer' abstract class

  /// </summary>

  public class DNCMouseInputAction : AbstractMouseInputAction

  {

    private DNCTicTacToeBoard _tictactoe;
    public DNCMouseInputAction(DNCTicTacToeBoard tictactoe, AbstractMouseInputMethod subject, string name)
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