namespace EffectiveCSharp._3_Generic
{
  using System;

  public class Session_Disposable
  {
    public static void Entry()
    {
    }

    public interface IEngine
    {
      void DoWork();
    }

    public class EngineDriver1<T> where T : IEngine, new()
    {
      public void GetThingsDone1()
      {
        var driver = new T();
        driver.DoWork();
      }

      public void GetThingsDone2()
      {
        var driver = new T();
        using (driver as IDisposable)  /* not (IDisposable)driver */
        {
          driver.DoWork();
        }

        // var a = driver as IDisposable;
        // driver.DoWork();
        // a?.Dispose();
      }
    }

    public class EngineDriver2<T> : IDisposable where T : IEngine, new()
    {
      private T driver = new T();
      public void GetThingsDone() => driver.DoWork();

      public void Dispose()
      {
        var resource = driver as IDisposable;
        resource?.Dispose();
      }
    }

    public class EngineDriver3<T> where T : IEngine, new()
    {
      private T driver;

      public EngineDriver3(T driver)
      {
        this.driver = driver;
      }

      public void GetThingsDone() => driver.DoWork();
    }
  }
}
