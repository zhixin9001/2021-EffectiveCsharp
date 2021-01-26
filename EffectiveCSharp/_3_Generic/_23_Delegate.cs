namespace EffectiveCSharp._3_Generic
{
  using System;

  public class _23_Delegate
  {
    public static void Entry()
    {
      Console.WriteLine(Example.Add(4, 5, (a, b) => a + b));
    }
  }

  public class Example
  {
    public static T Add<T>(T left, T right, Func<T, T, T> addFunc)
    {
      return addFunc(left, right);
    }
  }
}