 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Observer' abstract class

  /// </summary>

  public class BlazorInputAction : AbstractInputAction
  {
    public override void Update()
    {
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