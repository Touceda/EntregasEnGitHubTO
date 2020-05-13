using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionEstructuraDeDatos
{
    public class MiPila
    {
        private NodoPila PrimerNodo;
        private NodoPila NodoActual = null;
        public MiPila()
        {
            PrimerNodo = null;
        }

        public void Push(object dato)
        {
            //El if aplica para añadir el primer elemento a la Pila
            if (PrimerNodo == null)
            {
                NodoPila primerNodo = new NodoPila(dato, null) ;
                this.PrimerNodo = primerNodo;
                return;
            }


            //El Primero se duplica el primer nodo en el nodo actual
            NodoActual = PrimerNodo;
            //El nuevo Nodo apunta a la copia actual
            var NuevoNodo = new NodoPila(dato, NodoActual);
            //El Nodo Nuevo se convierte en el PrimerNodo
            PrimerNodo = NuevoNodo;
            //Se repite el ciclo por cada push
        }

        public object Pop()
        {      
            //primero extraigo el dato para devolverlo
            NodoActual = PrimerNodo;
            object devolverdato = NodoActual.Dato;
            //despues elimino el nodo
            PrimerNodo = NodoActual.AnteriorDato;
            return devolverdato;
        }
        public object Ver()
        {
            NodoActual = PrimerNodo;
            object devolverdato = NodoActual.Dato;
            return devolverdato;
        }

        public void MostrarPila()
        {
            NodoActual = PrimerNodo;
            while (NodoActual.AnteriorDato!=null)
            {             
                Console.WriteLine(NodoActual.Dato);
                NodoActual = NodoActual.AnteriorDato;
            }
            //para que se muestre el ultimo elemento de la pila
            Console.WriteLine(NodoActual.Dato);
        }
    }
       
}
