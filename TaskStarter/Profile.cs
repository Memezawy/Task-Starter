using System;
using System.Collections.Generic;

namespace TaskStarter
{
    [Serializable]
    public class Profile
    {
        public string Name { get; set; }

        public List<Task> Tasks = new List<Task>();

        public Profile(string name)
        {
            Name = name;
        }

        public Profile(string name, List<Task> tasks) : this(name)
        {
            Tasks = tasks;
        }

        public void StartTasks()
        {
            foreach (var process in Tasks)
            {
                process.Start();
            }
        }

        public void StopTasks()
        {
            foreach (var process in Tasks)
            {
                try
                {
                    if (!process.HasExited)
                    {
                        //only closes apps!
                        process.Kill();
                    }
                }
                catch (Exception ){}
                
            }
        }

        public void AddTask(string appPath, string taskName)
        {
            var process = new Task(taskName, appPath);
            Tasks.Add(process);
            Utiles.SaveProfiles();
        }

        public void RemoveTask(string taskName)
        {
            foreach (var t in Tasks)
            {
                if (t.Name != taskName) continue;
                Tasks.Remove(t);
                Utiles.SaveProfiles();
                return;
            }
        }
    }
}