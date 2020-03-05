 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Observer' abstract class

  /// </summary>

  public class DNCInputAction : AbstractInputAction
  {
    protected string _name;
    protected TicTacToeGame _observerState;
    protected DNCInputMethod _subject;
    private DNCTicTacToeBoard _tictactoe;

    public DNCInputAction(DNCTicTacToeBoard tictactoe, DNCInputMethod subject, string name)
    {
      this._tictactoe=tictactoe;
      this._name=name;
      this._subject=subject;
    }
    public override void Update()
    {
      _observerState = _subject.SubjectState;
      _tictactoe.Render();
    }
    // private int threshold;
    // private int total;

    // public Counter(int passedThreshold)
    // {
    //     threshold = passedThreshold;
    // }

    // public void Add(int x)
    // {
    //     total += x;
    //     if (total >= threshold)
    //     {
    //         ThresholdReachedEventArgs args = new ThresholdReachedEventArgs();
    //         args.Threshold = threshold;
    //         args.TimeReached = DateTime.Now;
    //         OnThresholdReached(args);
    //     }
    // }

    // protected virtual void OnThresholdReached(ThresholdReachedEventArgs e)
    // {
    //     EventHandler<ThresholdReachedEventArgs> handler = ThresholdReached;
    //     if (handler != null)
    //     {
    //         handler(this, e);
    //     }
    // }

    // public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;
 }

 }