using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            Divisao();            
        }

        static void Soma() 
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            float resultado = valor1 + valor2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.ReadKey();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            float resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.Write("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo Valor: ");
            float valor2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            float resultado = valor1 / valor2;
            Console.WriteLine($"O resultado da divisao é: {resultado}");
            Console.ReadKey();
        }
    }
}