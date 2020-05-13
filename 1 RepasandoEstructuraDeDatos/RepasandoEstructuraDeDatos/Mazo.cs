using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasandoEstructuraDeDatos
{
    abstract class Mazo
    {
        public List<int> MiMazo = new List<int>();
        public Mazo()
        {
            int carta = 1;
            for (int i = 0; i < 39; i++)
            {
                MiMazo.Add(carta);
                carta++;
            }
        }
    }
}
