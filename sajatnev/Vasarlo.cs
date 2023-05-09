using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sajatnev
{
    internal class Vasarlo
    {
        public int vasarloid;
        public string nev;
        public string email_cim;
        public string felhasznalonev;

        public Vasarlo(int vasarloid, string nev, string email_cim, string felhasznalonev)
        {
            this.vasarloid = vasarloid; 
            this.nev = nev;
            this.email_cim = email_cim;
            this.felhasznalonev = felhasznalonev;
        }
    }
}
