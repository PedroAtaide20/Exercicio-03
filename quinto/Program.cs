using System;

namespace quinto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = 1;


            Console.WriteLine("Digite um numero ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = numero; i > 0; i--)
            {
                Console.Write(i + "*");
                resultado = i * resultado;
            }
            Console.Write("=");
            Console.Write(" " + resultado);
            Console.ReadKey();
        }
    }
}
