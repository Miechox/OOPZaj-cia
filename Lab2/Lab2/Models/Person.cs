namespace Lab2.Models
{
    class Person
    {
        protected string name;
        public string Name { get; set; }
        protected int age;
        public int Age { get; set; }


        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public bool Equals(Person other)
        {
            if(other.age == this.age && other.name == this.name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        override public string ToString()
        {
            return $"Name: {this.name}, Age: {this.age}";
        }

    }
}
