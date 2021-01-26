namespace EffectiveCSharp._2_GC
{
  using System;
  using System.Diagnostics;
  using System.IO;

  public class _17_Dispose
  {
    public static void Entry()
    {
      
      File.WriteAllText("test1.txt","123");
      var a = new MyUnManaged();
      // using (var b = new MyUnManaged())
      // {
      //   
      // }
    }
  }

  public class UnManaged : IDisposable
  {
    private bool alreadyDisposed;

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool isDisposing)
    {
      if (alreadyDisposed)
        return;
      if (isDisposing)
      {
        // free managed resource here
      }

      // free unmanaged resource here
      alreadyDisposed = true;
    }

    public void ExampleMethod()
    {
      if (alreadyDisposed)
        throw new ObjectDisposedException(nameof(UnManaged), "Call methods on disposed object");

      // do something
    }

    ~UnManaged()
    {
      Dispose(false);
    }
  }

  public class MyUnManaged : UnManaged
  {
    private bool alreadyDisposedInDerived;

    protected override void Dispose(bool isDisposing)
    {
      if (alreadyDisposedInDerived)
        return;
      if (isDisposing)
      {
        // free managed resource here
      }

      // free unmanaged resource here

      base.Dispose(isDisposing); // call base.Disposes

      alreadyDisposedInDerived = true;
    }
  }
}