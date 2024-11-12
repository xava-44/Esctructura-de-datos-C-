using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Estructuras
{
    public partial class Forcirculares : Form
    {
        public static Nodo Inicio = null;
        public static Nodo Fin = null;
        public List<int> BusquedaList;
      
        public Forcirculares()
        {
            InitializeComponent();
            BusquedaList = new List<int>();
        }
        public class Nodo
        {
            public int valor;
            public Nodo sig;
            public Nodo previo;

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
                    int pos = int.Parse(cajaposicion.Text);
                    Nodo nuevo = new Nodo(valor, null);

                    if (Inicio==null&& Fin==null)
                    {
                        nuevo.sig = Inicio;
                        Inicio = nuevo;



                    }
                    else
                    {
                        Nodo aux = Inicio;
                        int indice = 0;

                        while (aux != null && indice < pos - 1)
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
                            Fin = nuevo;


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

        private void buscar_Click(object sender, EventArgs e)
        {

            if (Inicio == null&& Fin==null)
            {
                MessageBox.Show("no hay elementos en la lista");

            }
            else
            {
                int valor = int.Parse(cajabuscar.Text);
                Nodo aux = Inicio;
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

        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Inicio == null)
                {
                    MessageBox.Show("lista vacia");

                }
                else
                {


                    int pos = int.Parse(cajaeliminar.Text);


                    if (pos == 0)
                    {
                        int valorinicio = Inicio.valor;
                        Nodo aux = Inicio;
                        Inicio = Inicio.sig;
                        aux = null;



                    }
                    else
                    {
                        Nodo aux = Inicio;
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
                            Fin = aux;


                        }


                        nodotem = null;
                    }

                    cajaeliminar.Clear();
                    Mostrarelementos();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cajaeliminar.Clear();
            }



        }

        private void Mostrarelementos()
        {


            Valores.Items.Clear();
            Nodo aux = Inicio;

            while (aux != null)
            {
                Valores.Items.Add(aux.valor);
                aux = aux.sig;

            }

        }
    }

}
