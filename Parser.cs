
using System.Linq;

namespace CoreConsole
{
  public static class Parser
  {
    public static ICommand Parse(string commandString)
    {
      //--------------------------------
      var commandParts = commandString.Split(' ').ToList();
      var commandName = commandParts[0];
      //--------------------------------
      var args = commandParts.Skip(1).ToList();
      //--------------------------------
      switch (commandName)
      {
        case "exit": return new ExitCommand();
        case "echo": return new EchoCommand(args);
        default: return new UnknownCommand();
      }
      //--------------------------------
    }
  }
}