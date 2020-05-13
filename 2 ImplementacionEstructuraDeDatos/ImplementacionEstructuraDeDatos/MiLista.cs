using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionEstructuraDeDatos
{
    public class MiLista
    {
        private NodoList PrimerNodo;
        private NodoList NodoActual = null;
        private int cantElementos = 0;
        public MiLista()
        {
            PrimerNodo = null;
        }
    
        public void Add(object dato)        
        {
            //este if aplica solo para agregar el primer elemento a la Lista
            if (PrimerNodo == null)
            {
                NodoList primerNodo = new NodoList(dato,cantElementos);
                this.PrimerNodo = primerNodo;
                this.cantElementos++;
                return;
            }


            NodoActual = PrimerNodo;
            while (NodoActual.SiguienteDato != null)
            {
                NodoActual = NodoActual.SiguienteDato;
            }

            var nuevoNodo = new NodoList(dato, cantElementos);
            NodoActual.SiguienteDato = nuevoNodo;
            this.cantElementos++;
        }
        public object BuscarElemento(int index)
        {
            NodoActual = PrimerNodo; 

            while (NodoActual.Index != index) 
            {
                NodoActual = NodoActual.SiguienteDato;
                //con este if me devuelve un error si busco un indice muy alto
                if (NodoActual == null) 
                {
                    return "El indice exede la cantidad de elementos en la lista";
                }
            }                     
            return NodoActual.Dato; 
        }
        public int CantElementos()
        {           
            return cantElementos;
        }
    }
}
