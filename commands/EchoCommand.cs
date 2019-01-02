
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreConsole
{
  public class EchoCommand : ICommand
  {

    List<string> args { get; set; }

    public EchoCommand(List<string> args){
      this.args = args;
    }

    public bool Execute()
    {
      Console.WriteLine("You wrote 'echo' and : " + MergeArgs());
      return false;
    }


    string MergeArgs(){
      StringBuilder sb = new StringBuilder();
      foreach(string s in args){
        if(sb.ToString()!="")
        sb.Append(',');
        sb.Append(s);
      }
      return sb.ToString();
    }
  }
}