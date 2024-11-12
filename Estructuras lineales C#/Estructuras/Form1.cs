using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Form form1 = new ForPila();
            form1.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new Forcolas();
            form2.Show();
        }

        private void listasSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form3= new Forsimples();
            form3.Show();
        }

        private void listasDoblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form4 = new Fordobles();
            form4.Show();
        }

        private void listasCircularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form5 = new Forcirculares();
            form5.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
