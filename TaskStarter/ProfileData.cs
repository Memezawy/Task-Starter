using System;
using System.Collections.Generic;

namespace TaskStarter
{
    [Serializable]
    public class ProfileData
    {
        public string ProfileName { get; set; }
        public List<TaskData> TasksData = new List<TaskData>();

        public ProfileData(){}

        public ProfileData(string name)
        {
            ProfileName = name;
        }

        public ProfileData(string name, List<TaskData> datas) : this(name)
        {
            TasksData = datas;
        }

        public ProfileData(Profile p)
        {
            ProfileName = p.Name;
            foreach (var task in p.Tasks)
            {
                var taskData = new TaskData(task);
                TasksData.Add(taskData);
            }
        }
    }
}