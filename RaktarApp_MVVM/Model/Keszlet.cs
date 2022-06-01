using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop.Model
{
    class Keszlet
    {
        private string termeknev;
        private int mennyiseg;
        private string mennyisegmertek;
        private double egysegar;

        public Keszlet()
        {
            this.termeknev = string.Empty;
            this.mennyiseg = 0;
            this.mennyisegmertek = string.Empty;
            this.egysegar = 0;
        }

        public string Termeknev
        {
            get
            {
                return termeknev;
            }
            set
            {
                termeknev = value;
            }
        }

        public int Mennyiseg
        {
            get
            { return mennyiseg; }
            set
            { mennyiseg = value; }
        }

        public string Mennyisegmertek
        {
            get
            { return mennyisegmertek; }
            set
            { mennyisegmertek = value; }
        }

        public double Egysegar
        {
            get
            { return egysegar; }
            set
            { egysegar = value; }
        }


        public double TermekOsszAr
        {
            get
            {
                double termekOsszAr = (mennyiseg * egysegar);
                double roundedTermekOsszAr = Math.Round(termekOsszAr);
                return roundedTermekOsszAr;
            }
        }

        public string Termek
        {
            get
            {
                string output = "A termék neve: " + termeknev + '\n' + "Raktáron lévő mennyiség: " + mennyiseg + " " + mennyisegmertek + '\n' + "Egységára: " + egysegar + " Ft/" + mennyisegmertek;
                return output;
            }
        }


    }
}
