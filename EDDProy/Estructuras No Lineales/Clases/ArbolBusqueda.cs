using EDDemo.Estructuras_No_Lineales.Clases;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales
{
    public class ArbolBusqueda
    {
        NodoBinario Raiz;
        public String strArbol;
        public String strRecorrido;

        public ArbolBusqueda()
        {
            Raiz = null;
            strArbol = "";
            strRecorrido = "";
        }

        // metodo para podar el arbol, como parametro se pasa la referencia del nodo 
        public void PodarArbol(ref NodoBinario nodoPtr)
        {
            //comprobamos si el arbol esta vacio 
            if (nodoPtr == null)
                return;

            // Se elimina el subnodo izquierdo
            PodarArbol(ref nodoPtr.Izq);

            // Se elimina el subnodo derecho
            PodarArbol(ref nodoPtr.Der);

            // Se elimina el nodo actual
            nodoPtr = null;
        }

        // metodo para buscar el nodo menor de un arbol binario de busqueda
        public NodoBinario Buscarmenor(NodoBinario nodoPtr)
        {


            //comprobamos si el arbol esta vacio 
            if (nodoPtr == null)
            {
                return null;
            }
            // comprobamos si tiene hijos 
            else if (nodoPtr.Izq == null)
            {
                return nodoPtr;

            }
            else
            {
              // llamamos al metodo recursivamente pero con el siguiente nodo izquierdo
                return Buscarmenor(nodoPtr.Izq);
            }
        }

        // metodo para buscar el nodo mayor de un arbol binario de busqueda
        public NodoBinario Buscarmayor(NodoBinario nodoPtr)
        {
            //comprobamos si el arbol esta vacio 
            if (nodoPtr == null)
            {
                return null;
            }
            // comprobamos si tiene hijos 
            else if (nodoPtr.Der == null)
            {
                return nodoPtr;
            }
            else
            {  // llamamos al metodo recursivamente pero con el siguiente nodo derecho
                return Buscarmayor(nodoPtr.Der);
            }
        }


    // metodo para eliminar un nodo seleccionado y sutituido por el predecesor 
    // es decir con el nodo con el valor mas alto del lado zquierdo 
        public void EliminarPredecesor(int x, ref NodoBinario nodoPtr)
        {
            //comprobamos si el arbol esta vacio 
            if (nodoPtr == null)
            {
                return;
            }
            // si el dato es menor que el dato del nodo se busca del lado izquierdo
            else if (x < nodoPtr.Dato)
            {
            // se llama el metodo recurvivamente pero con los parametros modificados 
            // es decir con la referencia del nodo izquierdo 
                EliminarPredecesor(x, ref nodoPtr.Izq);
            }
            // si el daro es mayor que el dato del nodo , se busca del lado derecho
            else if (x > nodoPtr.Dato)
            {
                // se llama el metodo recurvivamente pero con los parametros modificados 
                // es decir con la referencia del nodo derecho
                EliminarPredecesor(x, ref nodoPtr.Der);
            }
            // Tiene dos hijos
            else if (nodoPtr.Izq != null && nodoPtr.Der != null)
            {
                
                NodoBinario mayor = Buscarmayor(nodoPtr.Izq);
                nodoPtr.Dato = mayor.Dato;
                EliminarPredecesor(mayor.Dato, ref nodoPtr.Izq);
            }
            else
            {
                // Tiene un solo hijo o ninguno
                NodoBinario temp = nodoPtr;
                if (nodoPtr.Izq == null)
                {
                    nodoPtr = nodoPtr.Der;
                }
                else
                {
                    nodoPtr = nodoPtr.Izq;
                }
                // Elimina el nodo
                temp = null; // El recolector de basura se encarga de liberar la memoria
            }
        }
        // metodo para eliminar un nodo seleccionado y sutituido por el sucesor
        public void EliminarSucesor(int x, ref NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
            {
                return;
            }
            else if (x < nodoPtr.Dato)
            {
                EliminarSucesor(x, ref nodoPtr.Izq);
            }
            else if (x > nodoPtr.Dato)
            {
                EliminarSucesor(x, ref nodoPtr.Der);
            }
            else if (nodoPtr.Izq != null && nodoPtr.Der != null)
            {
                // Tiene dos hijos
                NodoBinario menor = Buscarmenor(nodoPtr.Der);
                nodoPtr.Dato = menor.Dato;
                EliminarSucesor(menor.Dato, ref nodoPtr.Der);
            }
            else
            {
                // Tiene un solo hijo o ninguno
                NodoBinario temp = nodoPtr;
                if (nodoPtr.Izq == null)
                {
                    nodoPtr = nodoPtr.Der;
                }
                else
                {
                    nodoPtr = nodoPtr.Izq;
                }
                // Elimina el nodo
                temp = null; // El recolector de basura se encarga de liberar la memoria
            }
        }


        // metodo para contar la hojas de un arbol 
        public int Contarhojas(NodoBinario nodoptr)
        { // comprovamos si el arbol esta vacio 
            if (nodoptr == null)
                return 0;
         // si los nodos de ambos lados son nulos entonce retorna uno
            if (nodoptr.Der == null && nodoptr.Izq == null)
            {
                return 1;
            }
            else
                // se llama al metodo recursivamente sumando ambos lados
                return Contarhojas(nodoptr.Izq) + Contarhojas(nodoptr.Der);
        }

        public int Contarnodos(NodoBinario nodoptr)
        {
            if (nodoptr == null)
                return 0;

            else
                return 1 + Contarnodos(nodoptr.Izq) + Contarnodos(nodoptr.Der);
        }


        public void RecorridoNiveles(NodoBinario nodoPtr, Label label)
        {
            // Nodo auxiliar para recorrer el árbol
            NodoBinario nodoAuxiliar;

            // Cola para almacenar los nodos de cada nivel
            Queue<NodoBinario> colaAuxiliar = new Queue<NodoBinario>();

            // Añadir el nodo inicial a la cola
            colaAuxiliar.Enqueue(nodoPtr);
            string estcola = "";

            // Mientras la cola no esté vacía, continuar recorriendo
            while (colaAuxiliar.Count > 0)
            {
                // Extraer el primer nodo de la cola
                nodoAuxiliar = colaAuxiliar.Dequeue();

                estcola += nodoAuxiliar.Dato;

                // Si existe el hijo izquierdo, añadirlo a la cola
                if (nodoAuxiliar.Izq != null)
                    colaAuxiliar.Enqueue(nodoAuxiliar.Izq);

                // Si existe el hijo derecho, añadirlo a la cola
                if (nodoAuxiliar.Der != null)
                    colaAuxiliar.Enqueue(nodoAuxiliar.Der);


                label.Text = estcola;
                Application.DoEvents();

            }
        }


        public bool EsLleno(NodoBinario nodoPtr)
        {
            // Si el nodo es null, lo consideramos lleno
            if (nodoPtr == null)
            {
                return true;
            }

            // Si es una hoja (sin hijos), también es lleno
            if (nodoPtr.Izq == null && nodoPtr.Der == null)
            {
                return true;
            }

            // Si tiene ambos hijos, verificamos que ambos subárboles sean llenos
            if (nodoPtr.Izq != null && nodoPtr.Der != null)
            {
                return EsLleno(nodoPtr.Izq) && EsLleno(nodoPtr.Der);
            }

            // En cualquier otro caso, no es lleno
            return false;
        }
        public bool EsCompleto(NodoBinario nodoPtr)
        {
            if (nodoPtr == null)
                return true; // Un árbol vacío es completo

            NodoBinario nodoAuxiliar;
            Queue<NodoBinario> colaAuxiliar = new Queue<NodoBinario>();
            colaAuxiliar.Enqueue(nodoPtr); // Agregar el nodo raíz a la cola

            bool nodoNoLleno = false;

            while (colaAuxiliar.Count > 0)
            {
                nodoAuxiliar = colaAuxiliar.Dequeue(); // Obtener el primer nodo de la cola

                // Revisa si el nodo izquierdo está presente
                if (nodoAuxiliar.Izq != null)
                {
                    // Si hemos visto un nodo NO lleno y vemos un nodo con un nodo izquierdo ocupado,
                    // no es un árbol completo
                    if (nodoNoLleno)
                        return false;

                    colaAuxiliar.Enqueue(nodoAuxiliar.Izq); // Agregar el hijo izquierdo a la cola
                }
                else
                {
                    // Si el nodo izquierdo no está presente, entonces no es un árbol completo
                    nodoNoLleno = true;
                }

                // Revisa si el nodo derecho está presente
                if (nodoAuxiliar.Der != null)
                {
                    // Si hemos visto un nodo NO lleno y vemos un nodo con un nodo derecho ocupado,
                    // no es un árbol completo
                    if (nodoNoLleno)
                        return false;

                    colaAuxiliar.Enqueue(nodoAuxiliar.Der); // Agregar el hijo derecho a la cola
                }
                else
                {
                    // Si el nodo derecho no está presente, entonces no es un árbol completo
                    nodoNoLleno = true;
                }
            }

            return true;
        }

        public int Altura(NodoBinario nodoptr)
        {
            if (nodoptr == null)
            {
                return 0;
            }

            return (1 + Math.Max(Altura(nodoptr.Izq), Altura(nodoptr.Der)));


        }

        public Boolean Busqueda(int dato, NodoBinario nodo)
        {

            if (nodo == null)
            {
                return false;
            }
            else if (dato < nodo.Dato)
            {
                return Busqueda(dato, nodo.Izq);
            }
            else if (dato > nodo.Dato)
            {
                return Busqueda(dato, nodo.Der);
            }
            else
                return true;

        }


        public Boolean EstaVacio()
        {
            if (Raiz == null)
                return true;
            else
                return false;
        }

        //este medoto regresa un tipo de dato NodoBinario(un objeto )
        public NodoBinario RegresaRaiz()
        {
            return Raiz;
        }

        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null)
            {
                Nodo = new NodoBinario(Dato);

                if (Raiz == null)
                    Raiz = Nodo;
            }
            else if (Dato < Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Izq);
            else if (Dato > Nodo.Dato)
                InsertaNodo(Dato, ref Nodo.Der);
        }
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null)
                return;
            MuestraArbolAcostado(nivel + 1, nodo.Der);
            for (int i = 0; i < nivel; i++)
            {
                strArbol = strArbol + "      ";
            }
            strArbol = strArbol + nodo.Dato.ToString() + "\r\n";
            MuestraArbolAcostado(nivel + 1, nodo.Izq);
        }


        // Este metodo se encarga de dar el formato correcto toDot , recibiendo un nodo 
        // y regresando una cadena que posteriormente se usara en el metodo  StringBuilder
        public String ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder();
            if (nodo.Izq != null)
            {
                b.AppendFormat("{0}->{1} [side=L] {2} ", nodo.Dato.ToString(), nodo.Izq.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Izq));
            }

            if (nodo.Der != null)
            {
                b.AppendFormat("{0}->{1} [side=R] {2} ", nodo.Dato.ToString(), nodo.Der.Dato.ToString(), Environment.NewLine);
                b.Append(ToDot(nodo.Der));
            }
            return b.ToString();
        }

        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            strRecorrido = strRecorrido + nodo.Dato + ", ";
            PreOrden(nodo.Izq);
            PreOrden(nodo.Der);

            return;
        }

        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            InOrden(nodo.Izq);
            strRecorrido = strRecorrido + nodo.Dato + ", ";
            InOrden(nodo.Der);

            return;
        }
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null)
                return;

            PostOrden(nodo.Izq);
            PostOrden(nodo.Der);
            strRecorrido = strRecorrido + nodo.Dato + ", ";

            return;
        }

    }
}
