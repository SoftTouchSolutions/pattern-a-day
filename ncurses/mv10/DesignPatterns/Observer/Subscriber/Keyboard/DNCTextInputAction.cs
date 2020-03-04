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
  }

 }