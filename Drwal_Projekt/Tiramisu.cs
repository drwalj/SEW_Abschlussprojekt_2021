using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drwal_Projekt
{
    class Tiramisu : Product
    {
        public Tiramisu(decimal preis) : base("Tiramisu", preis, Typ.Dessert)
        {
        }
    }
}
