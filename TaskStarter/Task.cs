using System.Diagnostics;

namespace TaskStarter
{
    public class Task : Process
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public Task(string name, string path)
        {
            Name = name;
            Path = path;
            StartInfo.FileName = path;
        }
    }
}
