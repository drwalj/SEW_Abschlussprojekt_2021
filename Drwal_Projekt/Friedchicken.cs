using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drwal_Projekt
{
    class Friedchicken : Product
    {
        public Friedchicken(decimal preis) : base("Fried Chicken", preis, Typ.Hauptspeise)
        {
        }
    }
}
