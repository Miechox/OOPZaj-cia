namespace Lab2.Models
{
    class Tasks
    {
        private string name;
        private TaskStatus taskStatus;
        public string Name { get; set; }
        public TaskStatus Status { get; set; }
        public Tasks(string name,TaskStatus status)
        {
            this.name = name;
            this.Status = status;
        }
        public override string ToString()
        {
            return $"{this.name} [{this.Status}]\n";
        }
    }
}
