using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Casa:Vivienda
    {
        bool garage,fondo;
        public bool Garage
        {
            get { return garage; }
                set{garage=value;}
        }
        public bool Fondo
        {
            get { return fondo; }
            set { fondo = value; }
        }
        public Casa():base()
        {
            garage = false;
            fondo = false;
 
        }
        public Casa(int i, string c, double m, bool h, bool f):base(i,c,m)
        {
            garage = h;
            fondo = f;
 
        }
        public string MostrarCasa()
        {
            return base.MostrarVivienda() + "\t" + garage + "\t" + fondo;
        }

    }
}
