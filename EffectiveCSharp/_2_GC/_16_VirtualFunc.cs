namespace EffectiveCSharp._2_GC
{
  using System;
  using System.IO;
  using System.Threading.Tasks;

  public class _16_VirtualFunc
  {
    public static void Entry()
    {
      B1.Init();
    }
  }

  public class B
  {
    protected B()
    {
      VFunc();
    }

    protected virtual void VFunc()
    {
      Console.WriteLine("VFunc in B");
    }
  }
  

  public class B1 : B
  {
      private readonly string msg = "VFunc in B1";

      public B1(string msg)
      {
        this.msg = msg;
      }

      protected override void VFunc()
      {
        Console.WriteLine(msg);
      }

      public static void Init()
      {
        _ = new B1("Msg from main");
      }
  }
}