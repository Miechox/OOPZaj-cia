using System.Collections.Generic;
using System.Linq;

namespace Lab2.Models
{
    class Student : Person
    {
        protected string group;
        protected List<Tasks> tasks;
        public string Group { get; set; }
        public Student(string name, int age,string group) : base(name,age)
        {
            this.tasks = new List<Tasks>();
            this.name = name;
            this.age = age;
            this.group = group;
        }
        public Student(string name, int age, string group, List<Tasks> tasks) : base(name,age)
        {
            this.tasks = tasks;
            this.name = name;
            this.age = age;
            this.group = group;

        }
        public void AddTask(string taskName,TaskStatus taskStatus)
        {
            this.tasks.Add(new Tasks(taskName, taskStatus));
        }
        public void RemoveTask(int index)
        {
            this.tasks.Remove(this.tasks.ElementAt(index));
        }
        public void UpdateTask(int index, TaskStatus taskStatus)
        {
            this.tasks.ElementAt(index).Status = taskStatus;
        }
        public string RenderTask(string prefix = "\t")
        {
            return "";
        }
        public override string ToString()
        {
            string result = "";
            result += $"Student: {this.name} ({this.age} y.o.)\n";
            result += $"Group: {this.group}\n";
            result += "Tasks:\n";
            for (int i = 0; i < tasks.Count; i++)
            {
                result += $"{"\t"}{i + 1}. {this.tasks[i]}";
            }
            return result;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj == this) return true;
            
            Student student = obj as Student;

            if (student == null)
                return false;

            return base.Equals(obj) && SequenceEqual(this.tasks,student.tasks) && student.group == this.group;
        }
        private bool SequenceEqual(List<Tasks> a, List<Tasks> b)
        {
            // if a != null
            if (a != null)
                return a.SequenceEqual(b);
            else
                return false;
        }

    }
}
