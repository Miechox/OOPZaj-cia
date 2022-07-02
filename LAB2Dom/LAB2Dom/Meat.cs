using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2Dom
{
    internal class Meat : Product
    {
        public double Weight { get { return _weight;} set { _weight = value; } }
        private double _weight;

        public Meat(string name,double weight) : base(name)
        {
            this._weight = weight;
        }

        public override void Print(string prefix)
        {
            Console.WriteLine(prefix + $"{this.Name} ({this._weight} kg)");
        }
    }
}
