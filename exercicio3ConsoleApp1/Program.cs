using System;

namespace exercicio3ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool certo;
            double[] altura = new double[15];
            for (int s = 0; s < altura.Length; s++)
            {
                Console.WriteLine("Digite a altura da pessoa " + (s + 1));

            volta1:
                certo = double.TryParse(Console.ReadLine(), out altura[s]);
                if (certo == false)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opção inválida, digite novamente");
                    Console.ResetColor();
                    goto volta1;
                }


            }
            Array.Sort(altura);
            Console.WriteLine("mais alto : " + altura[14] + "\nmais baixo : " + altura[0]);
            Console.ReadKey();
        }
    }
}
