namespace EffectiveCSharp._3_Generic.Session
{
  using System;

  public class Session_Overload
  {
    public static void Entry()
    {
      MyDerived derived = new MyDerived();
      WriteMsg(derived);

      var msgWriter = derived as IMsgWriter;
      WriteMsg(msgWriter);

      var mbase = derived as MyBase;
      WriteMsg(mbase);
    }
    
    static void WriteMsg(MyBase b)
    {
      Console.WriteLine("Inside WriteMsg(MyBase b)");
    }

    static void WriteMsg<T>(T obj)
    {
      Console.WriteLine("Inside WriteMsg<T>(T obj)");
    }

    static void WriteMsg(IMsgWriter obj)
    {
      Console.WriteLine("Inside WriteMsg(IMsgWriter obj)");
    }
  }
  
  public class MyBase
  {
  }

  public interface IMsgWriter
  {
    void WriteMsg();
  }

  public class MyDerived : MyBase, IMsgWriter
  {
    public void WriteMsg() => Console.WriteLine("Inside MyDerived.WriteMsg");
  }
}