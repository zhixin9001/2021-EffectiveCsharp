namespace EffectiveCSharp._3_Generic
{
  using System;
  using System.Collections;
  using System.Collections.Generic;
  using System.IO;

  public class Session_Runtime
  {
    public static void Entry()
    {
      ArrayList arrayList = new ArrayList();
      arrayList.Add(2);
      arrayList.Add("two");
      arrayList.Add(null);
      
      foreach (var item in arrayList)
      {
        Convert.ToInt32(item);
      }

      var list = new List<int>();
      list.Add(2);
    }
  }
}
