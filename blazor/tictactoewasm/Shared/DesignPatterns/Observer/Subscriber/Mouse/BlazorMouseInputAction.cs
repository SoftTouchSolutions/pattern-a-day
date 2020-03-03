 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Observer' abstract class

  /// </summary>

  public class BlazorMouseInputAction : AbstractMouseInputAction

  {

    public BlazorMouseInputAction(AbstractMouseInputMethod subject, string name):base(subject,name)
    {
    }
  }

 }