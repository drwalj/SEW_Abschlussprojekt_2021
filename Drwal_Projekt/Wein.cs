using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drwal_Projekt
{
    class Wein : Product
    {
        public Wein(decimal preis) : base("Wein", preis, Typ.Alk)
        {
        }
    }
}
