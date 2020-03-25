
namespace Fg.Console
{
    public class Log
    {
        public string Data { get; private set; } = "";

        public void Line(string line) =>
            Data += line + "\n";

        public void Append(string data) =>
            Data += data;

        public void Info(string line) =>
            Line("[INFO] " + line);

        public void Warn(string line) =>
            Line("[WARN] " + line);

        public void Error(string line) =>
            Line("[ERR] " + line);

        public void Fatal(string line) =>
            Line("[FATAL] " + line);

        public void Clear() =>
            Data = "";
    }
}