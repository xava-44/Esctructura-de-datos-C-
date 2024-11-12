using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Estructuras_No_Lineales.Clases
{


    internal class Colas
    {
        public static NodoBinario inicio = null;
        public static NodoBinario final = null;
        public List<int> BusquedaList;



        public Colas() { }

        public class Nodo
        {
            public int valor;
            public Nodo sig;

            public Nodo(int valor, Nodo sig)
            {
                this.valor = valor;
                this.sig = sig;
            }



        }

        public void Enqueve( NodoBinario nodo)
        {
           


            if (final == null)
            {

                final = nodo;
                inicio = nodo;
            }
            else
            {
                final.Der = nodo;
                final = nodo;
            }


        }




    }


}
