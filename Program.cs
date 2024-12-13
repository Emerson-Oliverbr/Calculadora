using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());

            Console.WriteLine(valor1);
        }
    }
}