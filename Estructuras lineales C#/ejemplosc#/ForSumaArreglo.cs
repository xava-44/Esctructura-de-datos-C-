using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace ejemplosc_
{
    public partial class ForSumaArreglo : Form
    { // clase del formulario Suma de un arreglo
        public List<int> BusquedaList;
    // se crea un lista de tipo int , BusquedaList
        public ForSumaArreglo()
        {// constructor

            InitializeComponent();
            BusquedaList = new List<int>();
            
    // se inicializa la lista 
        }

        private void button2_Click(object sender, EventArgs e)
    // metodo privado del boton , el cual tiene un evento click ,este boton agrega elementos ala lista
        {
            try
            {
               
          
                int valor = int.Parse(textBox1.Text);
     // se le asigna a una variable de tipo int , el texto que recibe CajaTexto1 convitiendo a un tipo de dato int
               
                BusquedaList.Add(valor);
    // el valor que recibe de la caja de texto se agrega ala lista BusquedaList
              
                textBox1.Clear();
    //se usa un metodo para limpiar la caja textbox1
              
                Mostrarelementos();
    //se llama a un metodo , el cual muestra los elemento que se encuentran listbox(valores)
            
            }
            catch
    //se captura la excepcion 
            {
                MessageBox.Show("se supero los valores");
            }
        }


        private void button1_Click(object sender, EventArgs e)
     // metodo privado del boton , el cual tiene un evento click 
        {

            int cantidad = (int)numericUpDown1.Value;
    // el valor seleccionado con el componete numericupdown , se convierte a int y se le asigna a cantidad

            int[] numeros = new int[cantidad];
    // se crea un arreglo y se reserva espacio en memoria con la cantidad cantidad  
           
            numeros = BusquedaList.ToArray();
     // se convierte la lista BusquedaList a un arreglo en este caso es el arreglo numeros 

            while (cantidad < numeros.Length)
            {
     // Mostrar un mensaje de error y pedir al usuario que ingrese una nueva cantidad
                MessageBox.Show("Se ha superado el número de valores ingresados. Por favor, ajuste la cantidad.");

    // Pedir al usuario que ajuste la cantidad (en este caso, solo para fines demostrativos, reiniciamos el valor)
                numericUpDown1.Value = numeros.Length;
    // Restablecer el valor a la cantidad actual en caso de error

    // Salir del método si la cantidad no es válida
                return;
            }

            Stopwatch tiempo= Stopwatch.StartNew();
     // se una variable de la clase Stopwatch , usando un metodo para medir el tiempo 

            MessageBox.Show("Resultado de la suma:" + SumarElementos(numeros, 0));
    // se arroja un mensaje concatenado con el metodo SumarElemnetos pide un arreglo y un numero
            
            tiempo.Stop();
    // detiene el tiempo del contador 
            MessageBox.Show("El tiempo transcurrido es :" + tiempo.ElapsedMilliseconds+"ms");
    // se muestra el un mensaje con una cadena concatenado con la variable tiempo usando un metodo que muetra el tiempo en milisegundos
        }

        static int SumarElementos(int[] arreglo, int indice)
    // el metodo regresa la cantidad de la suma de los elementos de un arreglo
            {

                if (indice == arreglo.Length)
    // si ya se recorrio el arreglo , retorna 0
                {
                    return 0;
                }

                return arreglo[indice] + SumarElementos(arreglo, indice + 1);
    // sino el arreglo se suma al metodo SumarElementos incrementando en uno     
        }
        

        private void Mostrarelementos()
        {
            valores.Items.Clear(); 

            foreach (int item in BusquedaList)
            {
                valores.Items.Add(item);
            }

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


        }


        
        
    }
}
