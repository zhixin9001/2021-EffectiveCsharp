namespace EffectiveCSharp._4_Linq
{
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Linq;

  public class _31_Pipeline
  {
    public static void Entry()
    {
      IEnumerable<int> nums = new[] {1, 1, 2, 2, 3, 3};
      Unique(nums);
      foreach (var num in Square(Unique2(nums)))
      {
        var c = new BindingList<int>(new List<int>());
        Console.WriteLine(num);
      }
    }

    public static void Unique(IEnumerable<int> nums)
    {
      var unique = new HashSet<int>();
      foreach (var num in nums)
      {
        if (!unique.Contains(num))
        {
          unique.Add(num);
          Console.WriteLine(num);
        }
      }
    }

    public static IEnumerable<int> Unique2(IEnumerable<int> nums)
    {
      var unique = new HashSet<int>();
      Console.WriteLine("Entering V2");
      foreach (var num in nums)
      {
        if (!unique.Contains(num))
        {
          Console.WriteLine("Add");
          unique.Add(num);
          yield return num;

          Console.WriteLine("ReEntering V2");
        }
      }

      Console.WriteLine("Exit V2");
    }

    public static IEnumerable<int> Square(IEnumerable<int> nums)
    {
      foreach (var num in nums)
      {
        yield return num * num;
      }
    }
  }
}
