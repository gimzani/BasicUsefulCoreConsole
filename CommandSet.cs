using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CoreConsole
{
    public class CommandSet
    {
        //-------------------------------------------------------------
        public string Command { get; set; }
        public Dictionary<string, string> Args { get; set; }
        //-------------------------------------------------------------
        public CommandSet(string commandString)
        {
            //--------------------------------
            Args = new Dictionary<string, string>();
            //--------------------------------
            var commandParts = commandString.Split(' ').ToList();
            this.Command = commandParts[0];
            //--------------------------------
            MatchCollection singleDash = Regex.Matches(commandString, @"-\w\s\S+");
            foreach (Match m in singleDash)
            {
                string[] parts = m.Value.Split(new char[] { ' ' });
                string key = parts[0].Replace("-", "");
                string val = parts[1];
                Args.Add(key, val);
            }
            //--------------------------------
            MatchCollection doubleDash = Regex.Matches(commandString, @"--\w+\s\S+");
            foreach (Match m in doubleDash)
            {
                string[] parts = m.Value.Split(new char[] { ' ' });
                string key = parts[0].Replace("--", "");
                string val = parts[1];
                Args.Add(key, val);
            }
            //--------------------------------
        }
    }
}
