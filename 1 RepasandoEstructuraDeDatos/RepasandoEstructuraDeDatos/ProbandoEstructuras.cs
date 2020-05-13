using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasandoEstructuraDeDatos
{
    class ProbandoEstructuras
    {
        ProbandoCola Cola;
        ProbandoPila Pila;
        ProbandoLista Lista;
        public ProbandoEstructuras()
        {
            Cola = new ProbandoCola();
            Pila = new ProbandoPila();
            Lista = new ProbandoLista();
        }
        public void Play()
        {
            Console.WriteLine("A partir de un Mazo compuesto por 39 Cartas\ndonde la primer carta es la numero 1 y \nla ultima carta es la numero 39 Extraeremos\nlas primeras 5 cartas de cada mazo\nTeniendo en cuenta que todos los Mazos \nposeen diferentes estructuras de datos\n--------------------------------------------------------------------------------------------\n\n");
           
            Cola.Mostrar();
            Pila.Mostrar();

            Console.WriteLine("Tanto La Cola como la Pila son Listas Enlazadas\nYa que para extraer los elementos,\nse extraen uno por uno desde el primero hasta el ultimo\nUn ejemplo contratio seria una Lista (List)\nYa que puedo extraer las cartas por su indice\n");

            Lista.Mostrar();

            Console.ReadLine();
            return;
        }




    }
}
