
using System;

namespace SomaDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fale o primeiro número: ");
            double NumeroUm = Convert.ToDouble(Console.ReadLine());

            Console.Write("Fale o segundo número: ");
            double NumeroDois = Convert.ToDouble(Console.ReadLine());

            double Resultado = NumeroUm + NumeroDois;

            Console.WriteLine($"o resultado da soma dos dois números: {NumeroUm} + {NumeroDois} = {Resultado}");


        }
    }
}
