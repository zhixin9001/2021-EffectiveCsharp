namespace EffectiveCSharp._3_Generic
{
  using System;
  using System.Collections;
  using System.Collections.Generic;

  public class _25_Method
  {
    public static void Entry()
    {
      var a=Utils<string>.Max("c", "d");
      Console.WriteLine(a);

      var b = Utils<int>.Max(4, 3);
      Console.WriteLine(b.ToString());
      
      var c=Utils1.Max<string>("c", "d"); /* better to remove <string> */
      Console.WriteLine(c);
      
      var d = Utils1.Max(4, 3);
      Console.WriteLine(d.ToString());

      // var d1 = Utils1.Max(4d, 3d);
      // Console.WriteLine(d1.ToString());
    }

    public class Utils<T>
    {
      public static T Max(T left, T right)
      {
        return Comparer<T>.Default.Compare(left, right) > 0 ? left : right;
      }
    }
    
    public class Utils1
    {
      public static T Max<T>(T left, T right)
      {
        return Comparer<T>.Default.Compare(left, right) > 0 ? left : right;
      }

      public static int Max(int left, int right)
      {
        return Math.Max(left, right) > 0 ? left : right;
      }
      
      // public static double Max(double left, double right)
      // {
      //   return Math.Max(left, right) > 0 ? left : right;
      // }
    }
  }
}