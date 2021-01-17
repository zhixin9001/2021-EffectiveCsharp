namespace DefaultNamespace
{
  using System;

  public class _5_FormattableString
  {
    public static void Entry()
    {
      var a = $"the value of PI is {Math.PI}";
      Console.WriteLine(a);

      Action a2 = () => { };
      FormattableString a1 = $"the value of PI is {Math.PI}, E is {Math.E}";
      Console.WriteLine("Format: " + a1.Format);
      Console.WriteLine("Arguments: ");
      foreach (var arg in a1.GetArguments())
      {
        Console.WriteLine($"\t{arg}");
      }
    }
  }
}