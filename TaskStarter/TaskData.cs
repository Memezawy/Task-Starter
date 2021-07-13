using System;

namespace TaskStarter
{
    [Serializable]
    public class TaskData
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public TaskData(){}

        public TaskData(Task task)
        {
            Name = task.Name;
            Path = task.Path;
        }
    }
}