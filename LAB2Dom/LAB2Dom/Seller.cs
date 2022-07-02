using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2Dom
{
    internal class Seller : Person
    {
        public Seller(string name, int age) : base(name, age) { }
        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + $"Seller: {this.Name} ({this.Age} y.o.)");
        }

    }
}
