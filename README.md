# Basic Useful Core Console Application

This is a console application written in Dotnet Core.  

Most console apps are pretty useless and there are not a lot of tutorials out there to make a useful application.  
This is a step in the right direction.

## Structure

This uses a "Command Object" approach.  The "Main Program" is only there to execute commands and does so in a loop until the "Exit" 
command is issued.  This is done by reading commands from the console and feeding that command into a simple "Parser".

The Parser serves as a switchboard for command execution.

Commands must implement an ICommand interface which simply requires that each Command Object have an "Execute" function.

The Command executes and returns a boolean denoting whether or not to exit the application.

That's it.

Now wouldn't it have been nice to have a tutorial written that covers that?

