namespace DefaultNamespace
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class _1_Var
  {
    public static void Entry()
    {
      
      var f = GetMagicNumberDouble();
      var total = 100 * f / 6;
      Console.WriteLine($"Type: {total.GetType().Name}, Value: {total}");

      var f1 = GetMagicNumberFloat();
      var total1 = 100 * f1 / 6;
      Console.WriteLine($"Type: {total1.GetType().Name}, Value: {total1}");
      
      var f2 = GetMagicNumberDecimal();
      var total2 = 100 * f2 / 6;
      Console.WriteLine($"Type: {total2.GetType().Name}, Value: {total2}");
      
      var f3 = GetMagicNumberInt();
      var total3 = 100 * f3 / 6;
      Console.WriteLine($"Type: {total3.GetType().Name}, Value: {total3}");
      
      var f4 = GetMagicNumberLong();
      var total4 = 100 * f3 / 6;
      Console.WriteLine($"Type: {total4.GetType().Name}, Value: {total4}");
    }

    private static double GetMagicNumberDouble()
    {
      return 100;
    }

    private static float GetMagicNumberFloat()
    {
      return 100;
    }

    private static decimal GetMagicNumberDecimal()
    {
      return 100;
    }

    private static int GetMagicNumberInt()
    {
      return 100;
    }

    private static long GetMagicNumberLong()
    {
      return 100;
    }

    // public IEnumerable<string> FindCustomerStartWith(string start)
    // {
    //   IEnumerable<string> q =
    //     from c in db.Customers
    //     select c.ContactName;
    //   var q2 = q.Select(a => a.StartsWith(start));
    //   return q2;
    // }
    //
    // public IEnumerable<string> FindCustomerStartWith(string start)
    // {
    //   var q =
    //     from c in db.Customers
    //     select c.ContactName;
    //   var q2 = q.Select(a => a.StartsWith(start));
    //   return q2;
    // }
  }
}