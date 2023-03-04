// See https://aka.ms/new-console-template for more information
namespace LeerTeclado
{
    /// <summary>
    /// leer datos desde teclado
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("suma de dos numeros");
            Console.WriteLine("Ingresa numero 1:");
            // Los datos se leen como cadena
            string dato = Console.ReadLine();
            // Convertit a numero con int.Parse
            int n1 = int.Parse(dato);

            Console.WriteLine("Ingrsa numero 2:");
            dato = Console.ReadLine();
            int n2 = int.Parse(dato);
            int suma = n1 + n2;
            Console.WriteLine("El resultado es:{0}", suma);
        }
    }
}

