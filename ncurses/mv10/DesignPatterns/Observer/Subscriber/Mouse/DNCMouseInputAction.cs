 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Observer' abstract class

  /// </summary>

  public class DNCMouseInputAction : AbstractMouseInputAction

  {

    public DNCMouseInputAction(AbstractMouseInputMethod subject, string name):base(subject,name)
    {
    }
  }

 }