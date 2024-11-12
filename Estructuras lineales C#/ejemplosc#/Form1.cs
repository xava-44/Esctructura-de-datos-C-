using System.Configuration;

namespace ejemplosc_
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //este metodo se asocia al componente del boton , que tiene un evento de tipo click
        // Importante cuando se crea un componente tiene que concidir en el codigo
        private void Componente1_Click(object sender, EventArgs e)
        {
            // el componente cajatexto1 usa la propiedad texto para obtener el texto ingresado
            // y se le asgina ala variable mensaje
            // String mensaje = CajaTexto1.Text;

            // se desplega un mensaje en una venta 
            //  MessageBox.Show(mensaje);

        }


        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void SecuenciaDeFibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form form = new ForFibonacci();
            form.Show();

        }

        private void búsquedaBinariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form2 = new ForBusqueda();
            form2.Show();

        }

        private void algoritmoDeLaTorreDeHanoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form3 = new ForTorres();
            form3.Show();
        }

        private void factorialDeUnNúmeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form4 = new ForFactorial();
            form4.Show();

        }

        private void cálculoDeUnExponenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form5 = new ForExponentecs();
            form5.Show();
        }

        private void sumarLosElementosDeUnArregloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form6 = new  ForSumaArreglo ();
            form6.Show();
          
        }
    }


}
