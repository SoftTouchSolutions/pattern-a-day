 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Subject' abstract class

  /// </summary>

  abstract class AbstractInputMethod

  {
    private List<AbstractInputAction> _observers = new List<AbstractInputAction>();
 
    public void Attach(AbstractInputAction observer)
    {
      _observers.Add(observer);
    }
 
    public void Detach(AbstractInputAction observer)
    {
      _observers.Remove(observer);
    }
 
    public void Notify()
    {
      foreach (AbstractInputAction o in _observers)
      {
        o.Update();
      }
    }
  }
 
 }