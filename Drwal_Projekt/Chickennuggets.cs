using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drwal_Projekt
{
    class Chickennuggets : Product
    {
        public Chickennuggets(decimal price) : base("Chicken Nuggets", price, Typ.Hauptspeise)
        {
        }
    }
}
