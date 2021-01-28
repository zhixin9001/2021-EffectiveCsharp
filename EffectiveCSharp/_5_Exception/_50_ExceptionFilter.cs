namespace EffectiveCSharp._5_Exception
{
  using System;

  public class _50_ExceptionFilter
  {
    public static void Entry()
    {
      try
      {
        Filter();
      }
      catch (Exception e)
      {
      }
    }

    public static void Filter()
    {
      try
      {
        // ...
      }
      catch (Exception e) when (ForWhen(e)) { }
      catch (FormatException e)
      {
        // handle exception
      }
    }

    public static bool ForWhen(Exception e)
    {
      Console.WriteLine($"captured in when, msg:{e.Message}");
      return false;
    }
  }
}