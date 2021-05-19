using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beadandó
{
    class Atalakitott:Kerekpar
    {
        int teljesitmeny;
        string motor;

            
        public Atalakitott()
        {

        }
        public Atalakitott(string marka, string tipus, decimal tömeg, int teljesitmeny, string motor)
            : base(marka, tipus, tömeg)
        {
            this.Teljesitmeny = teljesitmeny;
            this.Motor = motor;
        }

        public Atalakitott(int teljesitmeny, string motor)
        {
            this.Teljesitmeny = teljesitmeny;
            this.Motor = motor;
        }

        public int Teljesitmeny { get => teljesitmeny; set => teljesitmeny = value; }
        public string Motor { get => motor; set => motor = value; }
    }
}
