using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionEstructuraDeDatos
{
    public class NodoCola
    {
        private object dato;
        private NodoCola siguienteNodo = null;
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
        public NodoCola SiguienteNodo
        {
            get
            {
                return siguienteNodo;
            }
            set
            {
                siguienteNodo = value;
            }
        }

        public NodoCola(object dato)
        {
            this.dato = dato;
        }
    }
}
