using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drwal_Projekt
{
    public class Product
    {
        public Product(string name, decimal price,Typ type)
        {
            Name = name;
            Price = price;
            Type = type;
        }

        public string Name { get; set; }
        public Typ Type { get; set; }
        public decimal Price { get; set; }

    }
}
