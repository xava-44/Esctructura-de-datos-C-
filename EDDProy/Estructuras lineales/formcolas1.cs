using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo
{
    public partial class formcolas1 : Form
    {  public static Nodo inicio = null;
        public static Nodo final = null;
        public List<int> BusquedaList;

        public formcolas1()
        {
            InitializeComponent();
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
    }
}
