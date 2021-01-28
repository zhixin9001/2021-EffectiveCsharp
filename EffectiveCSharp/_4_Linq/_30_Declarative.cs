namespace EffectiveCSharp._4_Linq
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class _30_Declarative
  {
    public static void Entry()
    {
    }

    public static IEnumerable<Tuple<int, int>> ProduceIndices()
    {
      for (var i = 0; i < 100; i++)
      {
        for (int j = 0; j < 100; j++)
        {
          yield return Tuple.Create(i, j);
        }
      }
    }

    public static IEnumerable<Tuple<int, int>> QueryIndices()
    {
      return
        from x in Enumerable.Range(0, 100)
        from y in Enumerable.Range(0, 100)
        select Tuple.Create(x, y);
    }

    public static IEnumerable<Tuple<int, int>> ProduceIndices1()
    {
      var storage = new List<Tuple<int, int>>();
      for (var i = 0; i < 100; i++)
      {
        for (int j = 0; j < 100; j++)
        {
          storage.Add(Tuple.Create(i, j));
        }
      }
      
      storage.Sort((point1, point2)=>
        (point2.Item1*point2.Item1+point2.Item2*point2.Item2)
        .CompareTo(point1.Item1*point1.Item1+point1.Item2*point1.Item2));

      return storage;
    }

    public static IEnumerable<Tuple<int, int>> QueryIndices1()
    {
      return
        from x in Enumerable.Range(0, 100)
        from y in Enumerable.Range(0, 100)
        orderby (x * x + y * y) descending
        select Tuple.Create(x, y);
    }
  }
}
