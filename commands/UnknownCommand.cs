
using System;

namespace CoreConsole
{
  public class UnknownCommand : ICommand
  {
    public bool Execute()
    {
      Console.WriteLine("Unknown Command.");
      return false;
    }
  }
}