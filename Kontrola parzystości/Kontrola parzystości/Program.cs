
using System;
using System.Linq;

namespace laboratorium_Hello_World
{
    internal class KontrolaParzystosci
    {
        public static void Main(string[] args)
        {
            string slowo = Console.ReadLine();
            int suma = 0;
            int x = 0;
    
            Console.Write("\n");

            foreach (int var in slowo)
            {
                char c = Convert.ToChar(var);
                Console.Write(c +" -> " + var + "\n");
            }

            Console.WriteLine("\nCRC:");
            foreach (int var in slowo)
            {
                for (int i = 0; i < 8; i++)
                {
                    x = (var >> i) & 1;
                    suma = suma ^ x;
                }
            }
            Console.Write(suma);
            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}