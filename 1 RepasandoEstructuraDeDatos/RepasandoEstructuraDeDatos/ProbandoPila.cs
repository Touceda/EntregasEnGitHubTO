using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasandoEstructuraDeDatos
{
    class ProbandoPila:Mazo
    {
        public Stack<int> MiMazoDePila;

        public ProbandoPila()
        {
            //Heredo List y lo convierto en Pila
            MiMazoDePila = new Stack<int>(MiMazo);
        }

        public void Mostrar()
        {
            Console.WriteLine("En Un Mazo de tipo -PILA-\nLas primeras 5 cartas que se pueden extraer son: \n\n");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Carta Numero: " + MiMazoDePila.Pop());
            }
            Console.WriteLine("-----------------------------------------------------\n\n");
        }
    }
}

