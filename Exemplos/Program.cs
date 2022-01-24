using System;

namespace Exemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de 5 notas!");
            Console.WriteLine("NOTA =>1");
            int nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("NOTA =>2");
            int nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("NOTA =>3");
            int nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("NOTA =>4");
            int nota4 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("NOTA =>5");
            int nota5 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;
            Console.WriteLine();
            Console.WriteLine("A media é => " + media);

        }
        
    }
}
