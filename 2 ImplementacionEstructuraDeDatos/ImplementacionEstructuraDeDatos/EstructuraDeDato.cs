using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacionEstructuraDeDatos
{
    public class EstructuraDeDato
    {
        public MiLista MyLista = new MiLista();
        public MiPila MyPila = new MiPila();
        public MiCola MyCola = new MiCola();
        public MiDictionary MyDictionary = new MiDictionary();

        public void Inicio()
        {
            int salida = 0;
            while (salida != 5)
            {
                salida = Menu();

                switch (salida)
                {
                    case 1: { Console.Clear(); ProbandoLista(); Console.ReadLine(); break; }
                    case 2: { Console.Clear(); ProbandoPila(); Console.ReadLine(); break; }
                    case 3: { Console.Clear(); ProbandoCola(); Console.ReadLine(); break; }
                    case 4: { Console.Clear(); ProbandoDictionary(); Console.ReadLine(); break; }
                    case 5: { Console.Clear(); salida = 5; break; }
                    default: { Console.Clear(); Console.WriteLine("input no reconocido\nPrecione enter y vuelva a intentar"); Console.ReadLine(); break; }
                }
                Console.Clear();
            }

            Console.Clear();
            Console.WriteLine("Fin del programa");
            Console.ReadLine();
        }
        private void ProbandoLista()
        {
            Console.WriteLine("Implementacion de List");
            Console.WriteLine("Tengo 3 Funciones:");
            Console.WriteLine("1- Funcion .Add para añadir elementos");

            MyLista.Add(5);
            MyLista.Add("Perro");
            MyLista.Add(10.5f);
            MyLista.Add("HolaMundo");
            MyLista.Add(200);
            Console.WriteLine("Los elementos fueron añadidos\n");

            Console.WriteLine("2- Funcion .CantElementos\nEsta funcion me devuelve un numero con la cantidad de elementos que tiene mi lista\n");
            Console.WriteLine("Actualmente mi Lista tiene " + MyLista.CantElementos().ToString() + " Elementos\ncontando el elemento que se encuentra en el index 0\n\n");

            Console.WriteLine("3- Funcion .BuscarElementos\nEsta funcion pide un indice para buscar en la lista y devuelve el elemento encontrado\n");
            var elemento = MyLista.BuscarElemento(2);
            Console.WriteLine("Elemendo buscado:" + elemento.ToString());
            Console.WriteLine("Elemendo buscado:" + MyLista.BuscarElemento(0).ToString());
            Console.WriteLine("Elemendo buscado:" + MyLista.BuscarElemento(3).ToString());
            Console.WriteLine("Elemendo buscado:" + MyLista.BuscarElemento(1500).ToString());
            Console.WriteLine("\n\n\n\n");
        }
        private void ProbandoPila()
        {
            Console.WriteLine("Implementacion de Pila");
            Console.WriteLine("Tengo 4 Funciones:");
            Console.WriteLine("1- Funcion .Push para apilar elementos");

            MyPila.Push(1);
            MyPila.Push(2);
            MyPila.Push(3);
            MyPila.Push(4);
            MyPila.Push(5);
            MyPila.Push(6);
            MyPila.Push(7);
            MyPila.Push(8);
            MyPila.Push(9);
            MyPila.Push("Diez");
            Console.WriteLine("Los elementos fueron apilados\n");

            Console.WriteLine("2- Funcion .MostrarPila que muestra todos los elementos de la Pila\n");
            MyPila.MostrarPila();

            Console.WriteLine("\n3- Funcion .Pop que me permite desapilar elementos de la Pila");
            Console.WriteLine("El elemento " + MyPila.Pop().ToString()+" Fue extraido de la Pila");
            Console.WriteLine("El elemento " + MyPila.Pop().ToString() + " Fue extraido de la Pila");
            Console.WriteLine("El elemento " + MyPila.Pop().ToString() + " Fue extraido de la Pila\n");

            Console.WriteLine("Llamamos a la funcion .MostrarPila nuevamente para ver como quedo nuestra Pila\n");
            MyPila.MostrarPila();

            Console.WriteLine("\n4- Funcion .Ver nos devuelve el primer elemento de la pila (igual que la funcion.Pop) pero sin eliminarlo");
            Console.WriteLine("Elemento actual que se encuentra en primer lugar es: " + MyPila.Ver().ToString());
            Console.WriteLine("Elemento actual que se encuentra en primer lugar es: " + MyPila.Ver().ToString());
            Console.WriteLine("Elemento actual que se encuentra en primer lugar es: " + MyPila.Ver().ToString());
            Console.WriteLine("\n\n\n\n");







        }
        private void ProbandoCola()
        {
            Console.WriteLine("Implementacion de Cola");
            Console.WriteLine("Tengo 3 Funciones:");
            Console.WriteLine("1- Funcion .Queue para añadir elementos\n");

            MyCola.Queue(1);
            MyCola.Queue(2);
            MyCola.Queue("tres");
            MyCola.Queue(4);
            MyCola.Queue(5);
            MyCola.Queue("sandia");
            Console.WriteLine("Los elementos fueron añadidos\n");

            Console.WriteLine("2-Funcion .MostrarCola nos muestra los elementos dentro de la Cola\n");
            MyCola.MostrarCola();

            Console.WriteLine("\n3-Funcion .DeQueue para devolver el primer elemento de la cola y eliminarlo");
            Console.WriteLine("El elemento " + MyCola.DeQueue().ToString() + " Fue extraido de la COLA");
            Console.WriteLine("El elemento " + MyCola.DeQueue().ToString() + " Fue extraido de la COLA");
            Console.WriteLine("El elemento " + MyCola.DeQueue().ToString() + " Fue extraido de la COLA");


            Console.WriteLine("\nLlamamos a la funcion .MostrarCola nuevamente para ver como quedo nuestra Cola\n");
            MyCola.MostrarCola();

            Console.WriteLine("\n4- Funcion .Ver nos devuelve el primer elemento de la Cola (igual que la funcion.Dequeue) pero sin eliminarlo");
            Console.WriteLine("Elemento actual que se encuentra en primer lugar es: " + MyCola.Ver().ToString());
            Console.WriteLine("Elemento actual que se encuentra en primer lugar es: " + MyCola.Ver().ToString());
            Console.WriteLine("Elemento actual que se encuentra en primer lugar es: " + MyCola.Ver().ToString());
            Console.WriteLine("\n\n\n\n");

        }
        private void ProbandoDictionary()
        {
            Console.WriteLine("Implementacion de Dictionary");
            Console.WriteLine("Tengo 3 Funciones:");
            Console.WriteLine("1- Funcion .Add para Añadir elementos");

            MyDictionary.Add("Juan",30);
            MyDictionary.Add("two",2.5f);
            MyDictionary.Add("Perro","Gato");
            MyDictionary.Add("A","B");
            MyDictionary.Add("z",10);
            MyDictionary.Add("Mil", "MILQUINIENTOS");
            MyDictionary.Add("Laura",39);
            MyDictionary.Add("Lucas",80);

            Console.WriteLine("Los elementos fueron añadidos\n");

            Console.WriteLine("2- Funcion .MostrarDictionary\nEsta funcion elemento por elemento, devolviendo la Key junto a su valor\n");
            Console.WriteLine("Key - Value");
            MyDictionary.MostrarDictionary();

            Console.WriteLine("\n3- Funcion.ObtenerValue nos permite ingresarle una key y nos devuelve su Value");
            Console.WriteLine(MyDictionary.ObtenerValue("Juan").ToString());
            Console.WriteLine(MyDictionary.ObtenerValue("Lucas").ToString());
            Console.WriteLine(MyDictionary.ObtenerValue("Chocolate").ToString());
            Console.WriteLine(MyDictionary.ObtenerValue("Perro").ToString());
            
            
            
            
        }

        public int Menu()
        {
            Console.WriteLine("Bienvenido a la App de Estructurad de Datos");
            Console.WriteLine("Precione 1 para probar Lista");
            Console.WriteLine("Precione 2 para probar Pila");
            Console.WriteLine("Precione 3 para porbar Cola");
            Console.WriteLine("Precione 4 para probar Dictionary");
            Console.WriteLine("Precione 5 para salir del programa");
            return int.Parse(Console.ReadLine());
        }
    }
}
