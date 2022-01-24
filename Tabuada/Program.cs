using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            // Recebe as Variaveis
            int formula, contador, numero;


            Console.Write("Digite o Numero da Taboada : ");
            numero = int.Parse(Console.ReadLine());

            //para
            for (contador = 1; contador <= 10; ++contador)
            {
                formula = numero * contador;
                Console.WriteLine(numero + " X " + contador + " = " + formula);

            }

            Console.ReadKey();
        }
    }
}
