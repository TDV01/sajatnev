using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sajatnev
{
    internal class Konyv
    {
        public int konyvID;
        public string szerzo;
        public string cim;
        public string isbn;
        public int ar;

        public Konyv(int konyvID, string szerzo, string cim, string isbn, int ar)
        {
            this.konyvID = konyvID;
            this.szerzo = szerzo;
            this.cim = cim;
            this.isbn = isbn;
            this.ar = ar;
        }
    }


}
