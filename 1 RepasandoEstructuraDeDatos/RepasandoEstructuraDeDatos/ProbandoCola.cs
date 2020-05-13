using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasandoEstructuraDeDatos
{
    class ProbandoCola:Mazo
    {
        public Queue<int> MiMazoDeCola;

        public ProbandoCola()
        {
            //Heredo List y lo convierto en Cola
            MiMazoDeCola = new Queue<int>(MiMazo);   
        }   

        public void Mostrar()
        {
            Console.WriteLine("En Un Mazo de tipo -COLA-\nLas primeras 5 cartas que se pueden extraer son: \n\n");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Carta Numero: " + MiMazoDeCola.Dequeue());
            }
            Console.WriteLine("-----------------------------------------------------\n\n");
        }
    }
}
