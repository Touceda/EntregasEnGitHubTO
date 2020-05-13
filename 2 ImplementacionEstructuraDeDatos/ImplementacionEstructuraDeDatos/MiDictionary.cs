using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionEstructuraDeDatos
{
    public class MiDictionary
    {
        NodoDictionary PrimerNodo = null;
        NodoDictionary ActualNodo = null;
        public void Add(object key, object value)
        {
            //este if aplica solo para agregar el primer elemento al dictionary
            if (PrimerNodo == null)
            {
                NodoDictionary primerNodo = new NodoDictionary(key,value);
                this.PrimerNodo = primerNodo;
                return;
            }


            ActualNodo = PrimerNodo;

            while (ActualNodo.SiguienteNodo != null)
            {
                ActualNodo = ActualNodo.SiguienteNodo;
            }

            NodoDictionary nuevoNodo = new NodoDictionary(key, value);
            ActualNodo.SiguienteNodo = nuevoNodo;
        }

        public object ObtenerValue(object key)
        {
            var auxiliar = PrimerNodo;
            ActualNodo = PrimerNodo;

            while (ActualNodo.SiguienteNodo!=null)
            {
                if (ActualNodo.Key == key) 
                {
                    object devolverDato = ActualNodo.Value;
                    return devolverDato;
                }
                ActualNodo = ActualNodo.SiguienteNodo;
            }

            //para verificar que el ultimo elemento no contenga la key 
            if (ActualNodo.Key == key)
            {
                object devolverDato = ActualNodo.Value;
                return devolverDato;
            }
            return "No se encontro la key";
        }

        public void MostrarDictionary()
        {
            ActualNodo = PrimerNodo;

            while (ActualNodo.SiguienteNodo != null)
            {
                Console.WriteLine(ActualNodo.Key.ToString()+" "+ActualNodo.Value.ToString());
                ActualNodo = ActualNodo.SiguienteNodo;
            }
            //para que se imprima el ultimo elemento de la lista al salir del while
            Console.WriteLine(ActualNodo.Key.ToString() + " " + ActualNodo.Value.ToString());
        }

    }
}
