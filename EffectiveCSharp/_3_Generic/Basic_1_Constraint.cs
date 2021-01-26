namespace EffectiveCSharp._3_Generic
{
  using System;
  using System.Diagnostics.CodeAnalysis;
  using System.IO;
  using static ConstraintTests;

  public class Basic_1_Constraint
  {
    public static void Entry()
    {
      TestStruct<DateTime>();
      
      // TestClass<Basic_1_Constraint>();
      
    }
  }

  public class ConstraintTests
  {

    public static void TestStruct<T>() where T : struct
    { }

    public static void TestClass<T>(T a)
    {
      // var c = new T();
      
    }
  }
}