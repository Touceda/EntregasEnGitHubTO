using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasandoEstructuraDeDatos
{
    class ProbandoLista:Mazo
    {
        public List<int> MiMazoDeLista;

        public ProbandoLista()
        {
            //Heredo List y lo convierto en Cola
            MiMazoDeLista = MiMazo;
        }

        public void Mostrar()
        {
            Console.WriteLine("En Un Mazo de tipo -Lista-\nextraigo 5 cartas de forma aleatoria por indice: \n\n");
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Carta Numero: " + MiMazoDeLista[r.Next(0,40)]);
            }
            Console.WriteLine("-----------------------------------------------------\n\n");
        }

    }
}
