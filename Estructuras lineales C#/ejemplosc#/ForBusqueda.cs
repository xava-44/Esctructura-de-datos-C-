using System.Diagnostics;
namespace ejemplosc_
{
    public partial class ForBusqueda : Form
    { //clase del formulario busqueda binaria
        public List<int> BusquedaList;
    // se crea un lista de tipo int , BusquedaList
        public ForBusqueda()
        {// constuctor 
            InitializeComponent();

            BusquedaList = new List<int>();
    // se inicializa la lista 
        }

        private void button1_Click(object sender, EventArgs e)
    // metodo privado del boton , el cual tiene un evento click ,este boton agrega elementos ala lista
        {

            try
     // se genera un excepcion 
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
                MessageBox.Show(" valor erroneo");
            }
        }

        private void Mostrarelementos()
    // este metod privado no retona valor y muestra los elementos que se agragaron ala BusquedaList
        {
            valores.Items.Clear();
    // se limpia la listbox llamada valores
            foreach (int item in BusquedaList)
    // ciclo foreach el cual itera con item
            {
                valores.Items.Add(item);
    // se agrega a listbox valores los elementos de la lista Busquedalist
            }

        }

        private void button2_Click(object sender, EventArgs e)
     // metodo privado del boton , el cual tiene un evento click 
        {
            int cantida =(int)numericUpDown1.Value;
     // el valor seleccionado con el componete numericupdown , se convierte a int y se le asigna a cantidad
            
            int num=int.Parse(textBox2.Text);
     // se le asigna a una variable de tipo int , el texto que recibe textBox2  convitiendo a un tipo de dato int
          
            int[]a = new int[cantida];
    // se crea un arreglo y se reserva espacio en memoria con la cantidad cantidad
          
            a=BusquedaList.ToArray();
    // se convierte la lista BusquedaList a un arreglo en este caso es el arreglo a 
          
            Stopwatch tiempo = Stopwatch.StartNew();
     // se una variable de la clase Stopwatch , usando un metodo para medir el tiempo 


            int indice = busqueda(a,num,0,a.Length);
    // ala variable indice se le asigna el numero que regresara el metodo busqueda , el cual pide como parametros
    // un arreglo(a) , el dato(num) , el inicio(0) y el final(a ) con el metodo .length
           
            tiempo.Stop();
     // se detiene le tiempo del contador 

            if (indice==-1)
    // condicional para comprobar si el valor es igual a uno 
            {
                MessageBox.Show("no se encontro el numero");
     // de ser asi ,arroja el mensaje no se enconto el numero     
            }  
            else
            { MessageBox.Show("el numero se encontro en la posicion ;" + indice);
    // sino ,arroja el mensaje que se encontro en el indice 
            }
            MessageBox.Show("El tiempo transcurrido es :" + tiempo.ElapsedMilliseconds + "ms");
     // se muestra el un mensaje con una cadena concatenado con la variable tiempo usando un metodo que muetra el tiempo en milisegundos
        }
        public static int busqueda(int[] A, int dato, int inicio, int final)    //O(log n)
     // este metodo regresa el indice donde se encontro el numero buscado dentro de un arreglo ordenado  
        {

            if (inicio > final)                                            //O(1)
     //condicional  si inicio es mayor que final , es decir no se encontro el numero ya que se supero el ultimo indice   
            {
                return -1;                                                      //O(1)

            }

            int mitad = (inicio + final) / 2;
    // se crea el centro del arreglo        
            if (A[mitad] == dato)                                               //O(1)
    // si en la mitad del arreglo es igual al numero buscado ,retorna el numero
            {
                return mitad;
            }

            else if (dato < A[mitad])                                             //O(1)
     // sino  si ,el dato buscado es menor que la mitad                                                                           
            {
                return busqueda(A, dato, inicio, mitad - 1);                    //O(log n)
     // si es asi retorna el metodo busqueda , pero decrementando la mitad en uno         
            }
            else { 

                return busqueda(A, dato, mitad + 1, final);                       //O(log n)
     // sino retorna el metodo pero sumando uno ala mitad        
            }                                                                      


        }





    }
}
