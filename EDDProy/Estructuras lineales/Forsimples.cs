using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras
{
    public partial class Forsimples : Form
    {
        public static Nodo inicio = null;
        public static Nodo final = null;
        public List<int> BusquedaList;
        public Forsimples()
        {
            InitializeComponent();
            BusquedaList = new List<int>();
        }
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

        private void insertar_Click(object sender, EventArgs e)
        {
          
            try
            {
                int valor = int.Parse(cajainsertar.Text);


                Nodo nuevo = new Nodo(valor, null);

                if (inicio== null)
                {
                    inicio = nuevo;
                    final = nuevo;
                }
                else
                {
                    nuevo.sig=inicio;
                    inicio=nuevo; 
                }
                BusquedaList.Add(valor);
                cajainsertar.Clear();
                Mostrarelementos();


            }
            catch (Exception ex)
            {
                MessageBox.Show("valor incorrecto");

            }



           

        }

        private void buscar_Click(object sender, EventArgs e)
        {

            if (inicio == null)
            {
                MessageBox.Show("no hay elementos en la lista");

            }
            else
            {
                int valor = int.Parse(cajabuscar.Text);
                Nodo aux = inicio;
                int pos = 0;
                bool encontrado = false;

                while (aux != null)
                {

                    if (valor == aux.valor)
                    {

                        MessageBox.Show("el valor buscado se encontro en la posicion:" + pos);
                        encontrado = true;
                        cajabuscar.Clear();
                        aux = null;
                    }
                    else
                    {
                        aux = aux.sig;
                    }


                    pos++;
                }

                if (!encontrado)
                {
                    MessageBox.Show("no se encontro el numero buscado");

                    cajabuscar.Clear();


                }




            }

        }






        private void insertarpocision_Click(object sender, EventArgs e)
        {
            if (inicio == null)
            {
                MessageBox.Show("no se acreado un lista");
            }
            else
            {

                try
                {
                    int valor = int.Parse(cajainsertarvalor.Text);
                    int pos = int.Parse(cajaposicion.Text);
                    Nodo nuevo = new Nodo(valor, null);
                   
                    if (pos == 0 )
                    {
                        nuevo.sig = inicio;
                        inicio = nuevo;
                        


                    }
                    else
                    {
                        Nodo aux = inicio;
                        int indice = 0;

                        while (aux != null && indice < pos -1)
                        {

                            aux = aux.sig;

                            indice++;
                        }

                        if (aux == null)
                        {
                            MessageBox.Show("posicion fuera de la lista ");
                        }

                        nuevo.sig = aux.sig;
                        aux.sig = nuevo;
                       


                        if (nuevo.sig == null)
                        {
                            final = nuevo; 
                   

                        }

                    }
                    BusquedaList.Add(valor);
                    cajainsertar.Clear();
                    Mostrarelementos();



                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se a creado un lista");
                }
            }
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            try {
                if (inicio == null)
                {
                    MessageBox.Show("lista vacia");

                }
                else
                {


                    int pos = int.Parse(cajaeliminar.Text);


                    if (pos == 0)
                    {
                        int valorinicio = inicio.valor;
                        Nodo aux = inicio;
                        inicio = inicio.sig;
                        aux = null;



                    }
                    else
                    {
                        Nodo aux = inicio;
                        int indice = 1;

                        while (aux != null && indice < pos - 1)
                        {

                            aux = aux.sig;

                            indice++;
                        }

                        if (aux == null || aux.sig == null)
                        {
                            MessageBox.Show("posicion fuera de la lista ");
                            return;
                        }

                        Nodo nodotem = aux.sig;
                        aux.sig = nodotem.sig;


                        if (nodotem.sig == null)
                        {
                            final = aux;


                        }


                        nodotem = null;
                    }

                    cajaeliminar.Clear();
                    Mostrarelementos();
                }
                

            }catch (Exception ex) {
            MessageBox.Show(ex.Message);
                cajaeliminar.Clear ( );
            }



        }

        private void Mostrarelementos()
        {
            Valores.Items.Clear(); 
            Nodo aux = inicio;

            while (aux != null) 
            {
                Valores.Items.Add(aux.valor); 
                aux = aux.sig; 

            }
        }

        private void vaciar_Click(object sender, EventArgs e)
        {

            if (inicio == null)
            {
                MessageBox.Show("pila vacia");

            }
            else
            {
                while (inicio != null)
                {
                    Nodo aux = inicio;
                    inicio = inicio.sig;
                    aux = null;
                }
                Valores.Items.Clear();
                BusquedaList.Clear();
            }
        }
    }
}
