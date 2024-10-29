using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDDemo.Estructuras_No_Lineales;

namespace EDDemo
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }       

        private void arbolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArboles mArboles = new frmArboles();
            mArboles.MdiParent = this;
            mArboles.Show();
        }

        private void estructurasNoLibealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pIlasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
                Form mPilas = new formpilas();
            mPilas.MdiParent = this;
            mPilas.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form colas = new formcolas1();
            colas.MdiParent = this;
            colas.Show();
        }
    }
}
