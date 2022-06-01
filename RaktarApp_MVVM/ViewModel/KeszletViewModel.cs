using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using oop.Model;
using ViewModel.BaseClass;

namespace RaktarApp_MVVM.ViewModel
{
    class KeszletViewModel : ViewModelBase
    {
        private Keszlet keszlet;

        public KeszletViewModel()
        {
            keszlet = new Keszlet();
        }

        public string Termeknev
        {
            get
            {
                return keszlet.Termeknev;
            }
            set
            {
                keszlet.Termeknev = value;

            }
        }

        public string Mennyiseg
        {
            get
            {
                return keszlet.Mennyiseg.ToString();
            }
            set
            {
                try
                {
                    int mennyiseg = Convert.ToInt32(value);
                    keszlet.Mennyiseg = mennyiseg;
                }
                catch (Exception) { }
            }
        }

        public string Mennyisegmertek
        {
            get
            {
                return keszlet.Mennyisegmertek;
            }
            set
            {
                keszlet.Mennyisegmertek = value;

            }
        }

        public string Egysegar
        {
            get
            {
                return keszlet.Egysegar.ToString();
            }
            set
            {
                try
                {
                    int egysegar = Convert.ToInt32(value);
                    keszlet.Egysegar = egysegar;
                }
                catch (Exception) { }
            }
        }

        public string TermekOsszAr
        {
            get
            {
                return keszlet.TermekOsszAr.ToString();
            }
        }


        public string Termek
        {
            get
            {
                return keszlet.Termek;
            }
        }

    }
}