using System;

namespace quarto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero para saber sua tabuada!");
            double numero = double.Parse(Console.ReadLine());

            double r1 = numero * 1;
            double r2 = numero * 2;
            double r3 = numero * 3;
            double r4 = numero * 4;
            double r5 = numero * 5;
            double r6 = numero * 6;
            double r7 = numero * 7;
            double r8 = numero * 8;
            double r9 = numero * 9;
            double r10 = numero * 10;

            Console.WriteLine($"{numero} * 1 = {r1}\n{numero} * 2 = {r2}\n{numero} * 3 = {r3}\n{numero} * 4 = {r4}\n{numero} * 5 = {r5}\n{numero} * 6 = {r6}\n{numero} * 7 = {r7}\n{numero} * 8 = {r8}\n{numero} * 9 = {r9}\n{numero} * 10 = {r10}\n");

            Console.ReadKey();
        }
    }
}
