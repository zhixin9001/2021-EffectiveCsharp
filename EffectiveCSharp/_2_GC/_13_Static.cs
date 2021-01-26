namespace EffectiveCSharp._2_GC
{
  using System;

  public class _13_Static
  {
    public static void Entry()
    {
      var t = new Test();
    }
  }

  public class Test
  {
    public static Lazy<string> value;
    static Test()
    {
      value = new Lazy<string>(()=>"");
    }

    public Test()
    {
      
    }
  }
}