using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplosc_
{
    public partial class ForTorres : Form
    {
        public ForTorres()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                int numeroDeDiscos = 3;                                                                         //O(1)
            ResolverTorresDeHanoi(numeroDeDiscos, 'A', 'C', 'B');     //O(2^n)
        }

                                                 
        


        static void ResolverTorresDeHanoi(int numeroDeDiscos, char origen, char destino, char auxiliar)     //O(2^n)
        {
            if (numeroDeDiscos == 1)                                                                         //O(1)
            {

                Console.WriteLine("Mueve el disco 1 de la torre {origen} a la torre {destino}");            //O(1)
            }
            else                                                                                                 //O(1)
            {

                ResolverTorresDeHanoi(numeroDeDiscos - 1, origen, auxiliar, destino);                        //O(2^n)


                Console.WriteLine("Mueve el disco {numeroDeDiscos} de la torre {origen} a la torre {destino}");    //O(1)


                ResolverTorresDeHanoi(numeroDeDiscos - 1, auxiliar, destino, origen);                           //O(2^ n)
            }
        }
    }
}

