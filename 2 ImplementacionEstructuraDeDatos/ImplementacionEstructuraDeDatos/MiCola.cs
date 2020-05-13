using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionEstructuraDeDatos
{
    public class MiCola
    {
        NodoCola PrimerNodo;
        NodoCola ActualNodo = null;
        public MiCola()
        {
            PrimerNodo = null; 
        }

        public void Queue(object dato)
        {
            //este if aplica solo para agregar el primer elemento a la Cola
            if (PrimerNodo == null)
            {
                NodoCola primerNodo = new NodoCola(dato);
                this.PrimerNodo = primerNodo;
                return;
            }


            ActualNodo = PrimerNodo;

            while (ActualNodo.SiguienteNodo != null) 
            {
                ActualNodo = ActualNodo.SiguienteNodo;
            }

            NodoCola nuevoNodo = new NodoCola(dato);
            ActualNodo.SiguienteNodo = nuevoNodo;
        }
        public object DeQueue()
        {
            //extraigo el dato
            ActualNodo = PrimerNodo;
            object devolverDato = ActualNodo.Dato;
            //luego lo desvinculo de la cola para eliminarlo
            ActualNodo = ActualNodo.SiguienteNodo;
            PrimerNodo = ActualNodo;

            return devolverDato;
        }
        public object Ver()
        {
            //extraigo el dato
            object devolverDato = PrimerNodo.Dato;

            return devolverDato;
        }
        public void MostrarCola()
        {
            ActualNodo = PrimerNodo;

            while (ActualNodo.SiguienteNodo != null) 
            {           
                Console.WriteLine(ActualNodo.Dato.ToString());
                ActualNodo = ActualNodo.SiguienteNodo;
            }
            //para que se imprima el ultimo elemento de la lista al salir del while
            Console.WriteLine(ActualNodo.Dato.ToString());
        }

    }
}
