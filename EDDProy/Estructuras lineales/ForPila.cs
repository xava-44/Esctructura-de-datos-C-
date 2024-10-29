using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Estructuras
{
    public partial class ForPila : Form
    {               
        public static Nodo top=null;
        public static Nodo bottom=null;
        public List<int> BusquedaList;
        public ForPila()
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int valor = int.Parse(cajainsertar.Text);
         
            
              Nodo nuevo = new Nodo(valor, null);

                if (top == null)
                {
                    top = nuevo;
                    bottom = nuevo;
                }
                else
                {
                    Nodo aux = top;
                    top = nuevo;
                    top.sig = aux;
                }
            BusquedaList.Add(valor);
            cajainsertar.Clear();
            Mostrarelementos();
                

            }
            catch (Exception ex) { 
            MessageBox.Show("valor incorrecto");
            
            }
                
        }

        private  void button2_Click(object sender, EventArgs e)
        {
              if (top == null)
                {
                    MessageBox.Show("no hay elementos en la pila");
                }
                else
                {
                    int valor = int.Parse(cajabuscar.Text);
                Nodo aux = top;
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

        private void Eliminar_Click(object sender, EventArgs e)
        {

            if (top == null)
            {
                MessageBox.Show("pila vacia");

            }
            else
            {
                int valor = top.valor;
                Nodo aux = top;
                top = top.sig;
                aux = null;
                MessageBox.Show("se elimino de la pila :" + valor);
                Valores.Items.Remove(valor);

            }
           

        }

        private void Vaciar_Click(object sender, EventArgs e)
        {
            
            if (top == null)
            {
                MessageBox.Show("pila vacia");

            }
            else
            {
                while (top != null)
                {
                    Nodo aux = top;
                    top=top.sig;
                    aux = null;
                }
                Valores.Items.Clear();  
                BusquedaList .Clear();
            }


        }

        private void Recorrer_Click(object sender, EventArgs e)
        {
            Nodo aux = top;
            while (aux != null)
            {
                //MessageBox.Show("valores de la pila:" + aux.valor);
                aux = aux.sig;

            }
           

        }

        private void Mostrarelementos()
        {
            //    Valores.Items.Clear();

            //    foreach (int item in BusquedaList)
            //    {
            //        Valores.Items.Add(item);
            //    }


            Valores.Items.Clear(); // Limpiar el ListBox antes de agregar los elementos

            Nodo aux = top; // Empezar desde el inicio de la lista

            while (aux != null) // Recorrer la lista
            {
                Valores.Items.Add(aux.valor); // Agregar el valor del nodo al ListBox
                aux = aux.sig; // Moverse al siguiente nodo

            }
        }

        private void ForPila_Load(object sender, EventArgs e)
        {

        }
    }
}
