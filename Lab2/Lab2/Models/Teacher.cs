namespace Lab2.Models
{
    class Teacher : Person
    {
        public Teacher(string name, int age): base (name,age)
        {
            this.name = name;
            this.age = age;
        }

        public override string ToString()
        {
            return $"Teacher: {this.name} ({this.age} y.o.)\n";
        }
    }
}
