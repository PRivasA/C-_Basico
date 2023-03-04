// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
namespace Sentencias
{
    internal class SentenciasUsing
    {
        public static void Main(string[] args)
        {
            string s;

            using (TextWriter w = File.CreateText("log.txt"))
            {
                w.WriteLine("linea uno");
                w.WriteLine("linea dos");
            }

            using (TextReader r = File.OpenText("log.txt"))
            {
                while ((s = r.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
            Console.ReadKey();
        }
    }
}
