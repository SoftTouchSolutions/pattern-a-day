using System;
using System.Collections.Generic;

namespace tictactoeweb.Shared.DesignPatterns{

  /// <summary>

  /// The 'Observer' abstract class

  /// </summary>

  public abstract class AbstractInputAction : PrintableObject

  {
    public abstract void Update();
  }

 }