namespace EffectiveCSharp._2_GC
{
  using System.Collections.Generic;

  public class _12_Init_Field
  {
  }

  public class MyClass
  {
    private List<string> labels;
    
    public MyClass(int size)
    {
      labels = new List<string>();
      labels = new List<string>(size);
    }
  }
}