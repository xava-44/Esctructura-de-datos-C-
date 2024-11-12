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
    public partial class ForFibonacci : Form
        // clase del formulario
    {
        public ForFibonacci()
            // constructor
        {
            InitializeComponent();
        }

        

        
        private void button1_Click(object sender, EventArgs e)
        {
     // metodo privado del boton , el cual tiene un evento click
         
            int num=int.Parse(CajaTexto2.Text);
     // se le asigna a una variable de tipo int , el texto que recibe CajaTexto2 convitiendo a un tipo de dato int

           
            Stopwatch tiempo = Stopwatch.StartNew();
     // se una variable de la clase Stopwatch , usando un metodo para medir el tiempo 

          
            MessageBox.Show("el resultado de la secuencia es : "+ secuencia(num));
     //  se muestra el mensaje con una cadena concatenado con el metodo secucian el cual recibe como parametro num
           
           
            tiempo.Stop();
     // se detiene el tiempo 
            
            MessageBox.Show("El tiempo transcurrido es :" + tiempo.ElapsedMilliseconds + "ms");
     // se muestra el un mensaje con una cadena concatenado con la variable tiempo usando un metodo que muetra el tiempo en milisegundos
        }
       
        
        public static int secuencia(int n)      // O(2^n)
     // metodo publico estatico que retorna la secuencia de un numero dado y recibe como parametro un int    
        {

            if (n == 0 || n == 1)  
     // condicional que compara a n con 1 o 0 si es igual regresara n            
            {

                return n;                       //O(1)
            }
           
            return secuencia(n - 1) + secuencia(n - 2);//O(2^n)
     // retorno  del metodo secuencia decrementando en uno el parametro sumando 
     // al mismo metodo pero decrementando en dos el parametro 
          


                }




       private void CajaTexto2_TextChanged(object sender, EventArgs e)
        {

        }

       private void label1_Click(object sender, EventArgs e)
        {

        }



    }
}
