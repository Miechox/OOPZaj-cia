using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2Dom
{
    internal class Product : IThing
    {
        public string Name { get { return _name; } set { _name = value; } }
        private string _name;

        public Product(string name)
        {
            _name = name;
        }
        public virtual void Print(string prefix)
        {
            Console.WriteLine("Product");
        }
    }
}
