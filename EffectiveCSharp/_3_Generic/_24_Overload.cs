namespace EffectiveCSharp._3_Generic
{
  using System;

  public class _24_Overload
  {
    public static void Entry()
    {
      MyDerived derived = new MyDerived();
      WriteMsg(derived);

      var msgWriter = derived as IMsgWriter;
      WriteMsg(msgWriter);

      var mbase = derived as MyBase;
      WriteMsg(mbase);
      
      var another =new AnotherType();
      WriteMsg(another);

      var anotherMsgWriter = another as IMsgWriter;
      WriteMsg(anotherMsgWriter);
    }

    static void WriteMsg(MyBase b)
    {
      Console.WriteLine("Inside WriteMsg(MyBase b)");
    }
    
    // static void WriteMsg(MyDerived b)
    // {
    //   Console.WriteLine("Inside WriteMsg(MyDerived b)");
    // }

    static void WriteMsg<T>(T obj)
    {
      Console.WriteLine("Inside WriteMsg<T>(T obj)");
    }

    static void WriteMsg(IMsgWriter obj)
    {
      Console.WriteLine("Inside WriteMsg(IMsgWriter obj)");
      // obj.WriteMsg();
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
    void IMsgWriter.WriteMsg() => Console.WriteLine("Inside MyDerived.WriteMsg");
  }

  public class AnotherType : IMsgWriter
  {
    public void WriteMsg() => Console.WriteLine("Inside AnotherType.WriteMsg");
  }
}