using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionEstructuraDeDatos
{
    public class NodoDictionary
    {
        //variables de mi nodo
        private object key;
        private object value;
        private NodoDictionary siguienteKey;

        //propiedades de mi nodo
        public object Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
            }
        }
        public object Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }
        public NodoDictionary SiguienteNodo
        {
            get
            {
                return siguienteKey;
            }
            set
            {
                siguienteKey= value;
            }
        }

        public NodoDictionary(object key, object value)
        {
            this.key =key;
            this.value = value;
            this.siguienteKey = null;
        }

    }
}
