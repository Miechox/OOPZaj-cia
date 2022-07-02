using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2Dom
{
    internal class Shop : IThing
    {
        public string Name
        {
            get { return _name; } set { _name = value; }
        }
        private string _name;
        private Person[] people;
        private Product[] products;

        public Shop(string name, Person[] people, Product[] products)
        {
            this._name = name;
            this.people = people;
            this.products = products;
        }

        public void Print()
        {
            Console.WriteLine($"Shop: {this.Name}");
            Console.WriteLine("-- People: --");
            foreach (Person person in this.people)
            {
                person.Print("\t");
            }
            Console.WriteLine("-- Products: --");
            foreach (Product product in this.products)
            {
                product.Print("\t");
            }
        }

    }
}
