using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2Dom
{
    internal class Fruit : Product
    {
        public int Count { get { return _count; } set { _count = value; } }
        private int _count;

        public Fruit(string name, int count) : base(name)
        {
            this._count = count;
        }

        public override void Print(string prefix)
        {
            string[] temp = { "fruit", "fruits" };
            Console.WriteLine(prefix + $"{this.Name} ({this._count} {(this._count>1?temp[0]:temp[1])})");
        }
    }
}
