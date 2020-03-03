using System;
using System.Collections.Generic;
 
 namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Subject' abstract class

  /// </summary>

  public abstract class AbstractInputMethod : PrintableObject

  {
    protected List<AbstractInputAction> _observers = new List<AbstractInputAction>();
 
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