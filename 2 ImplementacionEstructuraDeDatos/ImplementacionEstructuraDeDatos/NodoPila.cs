using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionEstructuraDeDatos
{
    public class NodoPila
    {
        //variables de mi nodo
        private object dato;
        private NodoPila anteriorDato;

        //propiedades de mi nodo
        public object Dato
        {
            get
            {
                return dato;
            }
            set
            {
                dato = value;
            }
        }
        public NodoPila AnteriorDato
        {
            get
            {
                return anteriorDato;
            }
            set
            {
                anteriorDato = value;
            }
        }

        public NodoPila(object dato, NodoPila anterior)
        {
            this.dato = dato;
            this.anteriorDato = anterior;
        }
    }
}
