using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drwal_Projekt
{
    class Kaiserschmarren : Product
    {
        public Kaiserschmarren(decimal preis) : base("Kaiserschmarren", preis, Typ.Dessert)
        {
        }
    }
}
