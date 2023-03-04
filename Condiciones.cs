// See https://aka.ms/new-console-template for more information
using System;
namespace Sentencias
{
    internal class SentenciaIf
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Ingrese un número:");
            int numeroEntero = int.Parse(Console.ReadLine());

            if (numeroEntero == 7)
                Console.WriteLine("numeroEntero es 7.");
            else if (numeroEntero < 0)
                Console.WriteLine("numeroEntero es negativo");
            else
                Console.WriteLine("numeroEntero no es ninguno de los casos programados");

            Console.ReadKey();

        }
    }
}
