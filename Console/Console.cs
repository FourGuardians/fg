using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Fg.Console
{
    public class Console : MonoBehaviour
    {
        public readonly List<Command> Commands = new List<Command>();
        public bool DebugMode = false;

        public void RegisterCommand(Command command)
        {
            Commands.Add(command);
        }

        public string Execute(string message)
        {
            List<string> args = new List<string>();
            args.AddRange(message.Split(' '));

            string cmd = args[0].ToLower();
            args.RemoveAt(0);

            Command command = Commands.FirstOrDefault(
            c =>
                c.Name.ToLower() == cmd ||
                Array.IndexOf(c.Aliases, cmd) > -1
            );

            if (command == null)
                return "[ERR] Invalid Command Specified!\n";

            if (command.Debug && !DebugMode)
                return "[ERR] This Command is only Available in Debug Mode!\n";

            command.Log.Clear();

            try 
            {
                command.Run(args, this);
            }
            catch (ArgumentOutOfRangeException)
            {
                command.Log.Error("Invalid Arguments!");
            }
            
            return command.Log.Data;
        }
    }
}