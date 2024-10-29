using EDDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;


//using GraphVizWrapper;
//using GraphVizWrapper.Queries;
//using GraphVizWrapper.Commands;

//using csdot;
//using csdot.Attributes.DataTypes;

namespace EDDemo.Estructuras_No_Lineales
{  
    // la clase frm(fomulario)Arboles , esta se encarga de concectar los conponectes  
    // del formulario con los metodos y atributos
    public partial class frmArboles : Form

    {   // se crea un atributo de tipo ArbolBusquda es un la clase que contiene todo los metodos de un arbol
        ArbolBusqueda miArbol;
        
        // este atributo es de tipo NodoBinario 
        // este objeto contiene sus propios atributos 
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }
    // componente boton para agregar un nodo al arbol
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {       //Obtenemos el nodo Raiz del arbol
                     miRaiz = miArbol.RegresaRaiz();

                int dato = int.Parse(txtDato.Text);

                if (miArbol.Busqueda(dato, miRaiz) == true)
                {

                    MessageBox.Show("el dato ya esta dentro del arbol");
                    return;
                }

               

                //Limpiamos la cadena donde se concatenan los nodos del arbol 
                miArbol.strArbol = "";

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(dato, ref miRaiz);

                //Leer arbol completo y mostrarlo en caja de texto
                miArbol.MuestraArbolAcostado(1, miRaiz);
                txtArbol.Text = miArbol.strArbol;

                txtDato.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se a ingresado un dato");
            }

 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
            lblRecorridoPreOrden.Text = "";
            lblRecorridoInOrden.Text = "";
            lblRecorridoPostOrden.Text = "";
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            String graphVizString;

            miRaiz = miArbol.RegresaRaiz();
            if (miRaiz == null)
            {
                MessageBox.Show("El arbol esta vacio");
                return;
            }

            StringBuilder b = new StringBuilder();
            b.Append("digraph G { node [shape=\"circle\"]; " + Environment.NewLine);
            b.Append(miArbol.ToDot(miRaiz));
            b.Append("}");
            graphVizString =  b.ToString();

            //graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            //graphVizString = @"digraph Arbol{Raiz->60; 60->40. 60->90; 40->34; 40->50;}";
            Bitmap bm = FileDotEngine.Run(graphVizString);

            
            frmGrafica graf = new frmGrafica();
            graf.ActualizaGrafica(bm);
            graf.MdiParent = this.MdiParent;
            graf.Show();
        }


        private void btnRecorrer_Click(object sender, EventArgs e)
        {
            //Recorrido en PreOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPreOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPreOrden.Text = "";
            miArbol.PreOrden(miRaiz);

            lblRecorridoPreOrden.Text = miArbol.strRecorrido;


            //Recorrido en InOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null)
            {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoInOrden.Text = "";
            miArbol.InOrden(miRaiz);
            lblRecorridoInOrden.Text = miArbol.strRecorrido;


            //Recorrido en PostOrden
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();
            miArbol.strRecorrido = "";

            if (miRaiz == null) {
                lblRecorridoPostOrden.Text = "El arbol esta vacio";
                return;
            }
            lblRecorridoPostOrden.Text = ""; 
            miArbol.PostOrden(miRaiz);
            lblRecorridoPostOrden.Text = miArbol.strRecorrido;
        }

        private void btnCrearArbol_Click(object sender, EventArgs e)
        {
            //Limpiamos los objetos y clases del anterior arbol
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text = "";
            txtDato.Text = "";
             
            miArbol.strArbol = "";

            Random rnd = new Random();

            for (int nNodos =1; nNodos < txtNodos.Value; nNodos++)
            {
                int Dato = rnd.Next(1, 100);
                //Obtenemos el nodo Raiz del arbol
                miRaiz = miArbol.RegresaRaiz();

                //Se inserta el nodo con el dato capturado
                miArbol.InsertaNodo(Dato, ref miRaiz);
            }

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.MuestraArbolAcostado(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;

            txtDato.Text = "";
        }

        

        private void botonbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(cajabusqueda.Text);
                miRaiz = miArbol.RegresaRaiz();

                if (miRaiz == null)
                {
                    MessageBox.Show("el arbol esta vaio ");
                    return;
                }
                if (miArbol.Busqueda(num, miRaiz) == true)
                {
                    MessageBox.Show("se ha encontrado el dato" + num);
                }
                else
                {
                    MessageBox.Show("valor no encontrado");
                }

            }
            catch (Exception ex) {
                MessageBox.Show("ingrese un dato!!!");
            }

        }


        private void frmArboles_Load(object sender, EventArgs e)
        {

        }

        private void txtArbol_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
