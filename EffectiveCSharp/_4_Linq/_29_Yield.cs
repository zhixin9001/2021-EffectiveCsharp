namespace EffectiveCSharp._4_Linq
{
  using System;
  using System.Collections.Generic;

  public class _29_Yield
  {
    public static void Entry()
    {
      ExceptionTest.A();

      foreach (var item in YieldTest.GetIntList())
      {
        Console.WriteLine(item.ToString());
      }
    }
  }

  public class YieldTest
  {
    public static IEnumerable<int> GetIntList()
    {
      var start = 0;
      while (start < 10)
      {
        yield return start;
        start++;
      }
    }
  }

  public class ExceptionTest
  {
    public static void A()
    {
      try
      {
        B();
      }
      catch (NullReferenceException e) when(e.Message=="c")
      {
        if (e.Message == "c")
        {
          throw ;
        }
      }
    }

    public static void B()
    {
      C();
    }

    public static void C()
    {
      throw new NullReferenceException("c");
    }
  }
}