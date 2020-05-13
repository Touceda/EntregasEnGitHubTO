using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionEstructuraDeDatos
{
    class NodoList
    {
        //variables de mi nodo
        private object dato;
        private NodoList siguienteDato;
        
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
        public NodoList SiguienteDato
        {
            get
            {
                return siguienteDato;
            }
            set
            {
                siguienteDato = value;
            }
        }

        public int Index { get; set; }

        public NodoList(object dato, int index)
        {
            this.dato = dato;
            this.siguienteDato = null;
            this.Index = index;
        }
       

    }
}
