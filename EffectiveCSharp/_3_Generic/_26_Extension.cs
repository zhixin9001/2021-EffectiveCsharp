namespace EffectiveCSharp._3_Generic
{
  using System;
  using System.Collections.Generic;
  using System.Linq;

  public class _26_Extension
  {
    public static void Entry()
    {
      // var myType =new MyType();
      // myType.NextMarker();
      // Console.WriteLine(myType.Marker);
      
      var myType =new MyType();
      var a = myType as IFoo;
      a.NextMarker();
      Console.WriteLine(a.Marker);
    }
  }

  public interface IFoo
  {
    int Marker { get; set; }
  }

  public static class FooExtension
  {
    public static void NextMarker(this IFoo foo)
    {
      foo.Marker++;
    }
  }
  
  public class MyType: IFoo
  {
    public int Marker { get; set; }

    public void NextMarker()
    {
      this.Marker += 5;
    }
  }
}