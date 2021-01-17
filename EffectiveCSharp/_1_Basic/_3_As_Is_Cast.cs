namespace DefaultNamespace
{
  using System;

  public class _3_As_Is_Cast
  {
    public static void Entry()
    {
      // As();
      // Cast();
      AsInt();
    }

    private static void As()
    {
      // object a = null; 
      object a = new TypeB();
      var b = a as TypeA;
      if (b != null)
      {
        Console.WriteLine("convert succeed");
      }
      else
      {
        Console.WriteLine("convert failed");
      }
    }

    private static void Cast()
    {
      // object a = null;
      object a= new TypeB();
      try
      {
        var a1 = a as TypeB;
        var b = (TypeA) a1;
        if (b != null)
        {
          Console.WriteLine("convert succeed");
        }
        else
        {
          Console.WriteLine("convert failed");
        }
      }
      catch (InvalidCastException e)
      {
        Console.WriteLine("convert failed");
      }
    }

    private static void AsInt()
    {
      object a = null;
      var b = a as int?;
      if (b.HasValue)
      {
        Console.WriteLine("convert succeed");
      }
      else
      {
        Console.WriteLine("convert failed");
      }
    }
  }

  public class TypeA
  {
  }

  public class TypeB
  {
    private TypeA _typeA =new TypeA();

    public static implicit operator TypeA(TypeB typeB)
    {
      return typeB._typeA;
    }
  }

  public class TypeC 
  {
  }
}