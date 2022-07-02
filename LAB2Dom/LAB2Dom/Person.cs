using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2Dom
{
    internal class Person : IThing
    {
        public string Name { get { return _name; } set { _name = value; } }
        private string _name;

        public int Age { get { return _age; } set { _age = value <= 0? 1 : value; } }
        private int _age;


        public Person(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public virtual void Print(string prefix)
        {
            Console.WriteLine("Person:");   
        }
    }
}
