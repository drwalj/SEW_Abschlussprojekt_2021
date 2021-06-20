using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drwal_Projekt
{
    class Eistee : Product
    {
        public Eistee(decimal preis) : base("Eistee", preis, Typ.Kaltgetränk )
        {
        }
    }
}
