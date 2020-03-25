using System.Collections.Generic;

namespace Fg.Console
{
    public abstract class Command
    {
        public Log Log = new Log();

        public abstract string Name { get; }
        public virtual bool Debug { get; } = false;
        public virtual string Description { get; } = "No description";
        public virtual string[] Aliases { get; } = {};

        public abstract void Run(List<string> args, Console console);
    }
}