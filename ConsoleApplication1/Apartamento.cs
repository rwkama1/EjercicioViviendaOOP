using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Apartamento:Vivienda
    {
        double gastoscomunes;
        double piso;
        public double Gastoscomunes
        {
            get 
            {
                return gastoscomunes;
            }
            set{gastoscomunes=value;}

        }
        public double Piso
        {
            get { return piso; }
            set { piso = value; }
        }
        public Apartamento():base()
        {
            gastoscomunes = 0;
            piso = 0;
        }
        public Apartamento(int i, string c, double m,double g,double p)
            : base(i,c,m)
        {
            gastoscomunes = m;
            piso = p;
 
        }
        public string MostrarApartamento()
        {
            return base.MostrarVivienda() + "\t" + gastoscomunes + "\t" + piso;
        }

    }
}
