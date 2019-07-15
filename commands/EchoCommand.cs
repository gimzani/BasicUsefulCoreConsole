using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsole
{
    public class EchoCommand : ICommand
    {

        public CommandSet commandSet { get; set; }

        public EchoCommand(CommandSet cs)
        {
            this.commandSet = cs;
        }

        public bool Execute()
        {
            Console.WriteLine("You wrote 'echo' and has Args : " + MergeArgs());
            return false;
        }

        public string MergeArgs()
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, string> kvp in commandSet.Args)
            {
                if (sb.ToString() != "")
                    sb.Append(", ");
                sb.Append(kvp.Key + "=" + kvp.Value);
            }
            return sb.ToString();
        }
    }
}