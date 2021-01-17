namespace DefaultNamespace
{
  using System;

  public class _7_EventAndNull
  {
    public static void Entry()
    {
      var source = new EventSource();
      source.Update += i => Console.WriteLine(i * 2);
      source.RaiseUpdate();
    }
  }

  public class EventSource
  {
    public event Action<int> Update;
    public void RaiseUpdate()
    {
      Update?.Invoke(2);
    }
  }
}