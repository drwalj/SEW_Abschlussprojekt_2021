using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drwal_Projekt
{
    class Icecream : Product
    {
        public Icecream(decimal preis) : base("Ice Cream", preis, Typ.Dessert)
        {

        }
    }
}
