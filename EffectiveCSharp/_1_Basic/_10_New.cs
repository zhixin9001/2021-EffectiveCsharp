namespace DefaultNamespace
{
  using System;

  public class _10_New
  {
    public static void Entry()
    {
      object c = new MyOtherClass();
      var c1 =c as MyClass;
      c1.MagicMethod();
      
      var c2 =c as MyOtherClass;
      c2.MagicMethod();
    }
  }

  public class MyClass
  {
    public virtual void MagicMethod()
    {
      Console.WriteLine("MyClass");
    }
  }

  public class MyOtherClass : MyClass
  {
    public override void MagicMethod()
    {
      Console.WriteLine("MyOtherClass");
    }
  }
}