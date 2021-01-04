using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Vivienda
    {
        //ATRIBUTOS
        int id;
        string calle;
        double metro;
        double precio;
        //PROPIEDADES
        public int Id
        {
            get { return id;}
            set { id = value; }
        }
        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }
        public double Metro
        {
            get { return metro; }
            set { metro = value; }
        }
        //CONSTRUCTORES
        public Vivienda()
        {
            id = 0;
            calle="";
            metro=0;
            precio = 0;
        }
        public Vivienda(int i, string c, double m)
        {
            id = i;
            calle = c;
            metro = m;
            precio = 0;
        }
        //METODOS
        public string MostrarVivienda()
        {
            return id+ "\t" + calle+ "\t" +metro+ "\t" +precio;
        }

    }
}
