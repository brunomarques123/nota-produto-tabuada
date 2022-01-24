using System;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor informar o nome do PRODUTO:");
            string nome = string.Format(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Informar o valor do PRODUTO");
            double valor = double.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Qual a porcentagem de desconto?");
            double porcentagem = double.Parse(Console.ReadLine());
            Console.WriteLine();

            double porcentagemDesc = porcentagem / 100;

            double valorFinal = valor - (porcentagemDesc * valor);

            Console.WriteLine("O Produto " + nome + " de valor R$ " + valor + " Com desconte de % " + porcentagem +" Saira por Apenas: R$ " + valorFinal);
        }
    }
}
