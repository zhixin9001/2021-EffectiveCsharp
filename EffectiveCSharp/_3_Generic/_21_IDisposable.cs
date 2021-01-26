namespace EffectiveCSharp._3_Generic
{
  using System;
  using System.IO;

  public class _21_IDisposable
  {
    public static void Entry()
    {
      // new EngineDriver1<UnManaged>().GetThingsDone();
      
      // using var a = new EngineDriver2<UnManaged>();
      // a.GetThingsDone();

      using (var driver = new UnManaged())
      {
        var a = new EngineDriver3<UnManaged>(driver);
        
      }
    }
  }

  public class UnManaged : IEngine, IDisposable
  {
    private bool alreadyDisposed;

    public void Dispose()
    {
      GC.SuppressFinalize(this);
    }

    public void DoWork()
    {
    }
  }

  public interface IEngine
  {
    void DoWork();
  }

  public class EngineDriver1<T> where T : IEngine, new()
  {
    public void GetThingsDone()
    {
      var driver = new T();
      using (driver as IDisposable)
      {
        driver.DoWork();
      }

      // using (var dr = new T())
      // {
      //   
      // }

      var a = driver as IDisposable;
      driver.DoWork();
      a?.Dispose();
    }
  }

  public sealed class EngineDriver2<T> : IDisposable where T : IEngine, new()
  {
    // it's expensive to create, so create to null
    private Lazy<T> driver = new Lazy<T>(() => throw new Exception());
    public void GetThingsDone() => driver.Value.DoWork();

    public void Dispose()
    {
      if (driver.IsValueCreated)
      {
        var resource = driver.Value as IDisposable;
        resource?.Dispose();
      }
    }
  }
  
  public sealed class EngineDriver3<T> where T : IEngine
  {
    private T driver;

    public EngineDriver3(T driver)
    {
      this.driver = driver;
    }
  }
}