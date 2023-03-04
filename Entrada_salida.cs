// See https://aka.ms/new-console-template for more information
using System;
namespace Fundamentos
{
    class EntradaSalida
    {
        public static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Escribe tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola" + nombre);
            Console.Read();
        }
    }
}


