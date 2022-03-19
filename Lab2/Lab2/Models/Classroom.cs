namespace Lab2.Models
{
    class Classroom
    {
        private string name;
        private Person[] persons;
        public string Name { get; set; }

        public Classroom(string name,Person[] persons)
        {
            this.name = name;
            this.persons = persons;
        }
        public override string ToString()
        {
            string result = "";
            result += $"Classroom: {this.name}";
            for(int i = 0;i<persons.Length;i++)
            {
                result += persons[i].ToString();
            }
            return result;
        }

    }
}
