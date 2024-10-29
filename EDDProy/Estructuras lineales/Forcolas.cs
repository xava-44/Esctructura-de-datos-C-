using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Estructuras.ForPila;

namespace Estructuras
{
    public partial class Forcolas : Form
    {
        public static Nodo inicio= null;
        public static Nodo final = null;
        public List<int> BusquedaList;
        public Forcolas()
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

                if (final == null)
                {
                   
                    final = nuevo;
                    inicio = nuevo;
                }
                else
                {
                    final.sig = nuevo;
                    final=nuevo;
                }

                BusquedaList.Add(valor);
                cajainsertar.Clear();
                Mostrarelementos();
            }
            catch (Exception ex) {

                MessageBox.Show("dato incorrecto");
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {


            if (inicio == null)
            {
                MessageBox.Show("no hay elementos en la cola");

            }

            else
            {
                int valor = int.Parse(cajabuscar.Text);
                Nodo aux = inicio;
                int pos = 1;
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
            if (inicio == null)
            {

                MessageBox.Show("cola vacia");
                final=null;
            }
            else
            {
                int valor =inicio.valor;
                Nodo aux = inicio;
                inicio = inicio.sig;
                aux = null;
                MessageBox.Show("se elimino el valor" + valor + "de la cola");
                Valores.Items.Remove(valor);
            }
        }
   
    
    
           

        private void vaciar_Click(object sender, EventArgs e)
        {
            if (inicio == null)
            {
                MessageBox.Show("la cola esta vacia");

            }
            else
            {
                while (inicio != null)
                {
                    Nodo aux = inicio;
                    inicio=inicio.sig;
                    aux = null;
                }
                Valores.Items.Clear();
                BusquedaList.Clear();
            }
        }
        
        private void Mostrarelementos()
        {
            Valores.Items.Clear();

            foreach (int item in BusquedaList)
            {
                Valores.Items.Add(item);
            }

        }

    }
}
