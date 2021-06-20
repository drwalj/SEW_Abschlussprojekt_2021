using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drwal_Projekt
{
    class Choccymilk : Product
    {
        public Choccymilk(decimal preis) : base("Choccy Milk", preis, Typ.Warmgetränk)
        {
        }
    }
}
