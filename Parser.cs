namespace CoreConsole
{
    public static class Parser
    {
        public static ICommand Parse(string commandString)
        {
            //--------------------------------
            CommandSet commandSet = new CommandSet(commandString);
            //--------------------------------
            switch (commandSet.Command)
            {
                case "exit": return new ExitCommand();
                case "echo": return new EchoCommand(commandSet);
                default: return new UnknownCommand();
            }
            //--------------------------------
        }
    }
}