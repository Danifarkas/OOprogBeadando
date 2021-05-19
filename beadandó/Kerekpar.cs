using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadandó
{
    class Kerekpar
    {
        string marka, tipus;
        decimal tömeg;
        

        public Kerekpar()
        {
        }

        public Kerekpar(string marka, string tipus, decimal tömeg)
        {
            this.marka = marka;
            this.tipus = tipus;
            this.tömeg = tömeg;
        }

        public string Marka { get => marka; set => marka = value; }
        public string Tipus { get => tipus; set => tipus = value; }
        public decimal Tömeg { get => tömeg; set => tömeg = value; }
    }
}
