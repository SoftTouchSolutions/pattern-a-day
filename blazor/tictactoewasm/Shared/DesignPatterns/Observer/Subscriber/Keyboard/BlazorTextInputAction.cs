 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Observer' abstract class

  /// </summary>

  public class BlazorTextInputAction : AbstractTextInputAction

  {
    public BlazorTextInputAction(AbstractTextInputMethod subject, string name):base(subject,name)
    {
    }
  }

 }