
using System;

namespace CoreConsole
{
  public class ExitCommand : ICommand
  {
    public bool Execute()
    {
      Console.WriteLine("Goodbye.");
      return true;
    }
  }
}