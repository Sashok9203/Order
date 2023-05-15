using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    internal class Product
    {
        public string Name { get; }
        public double Price { get; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
           return $"{Name}{new string(' ',(25 - Name.Length)*2)} - {Price} гр.";
        }
    }
}
